namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models.Enums;
    using VaporStore.DataProcessor.Dto.Export;

    public static class Serializer
	{
		public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
		{
			var result = context.Genres
				.ToArray()
				.Where(g => genreNames.Contains(g.Name))
				.Select(x => new
				{
					Id = x.Id,
					Genre = x.Name,
					Games = x.Games.Where(ga => ga.Purchases.Count > 0).Select(ga => new
					{
						Id = ga.Id,
						Title = ga.Name,
						Developer = ga.Developer.Name,
						Tags = string.Join(", ", ga.GameTags.Select(gt => new string(gt.Tag.Name))),
						Players = ga.Purchases.Count
					})
					.OrderByDescending(g => g.Players)
					.ThenBy(g => g.Id)
					.ToArray(),
					TotalPlayers = x.Games.Where(ga => ga.Purchases.Count > 0).Sum(g => g.Purchases.Count)
				})
				.OrderByDescending(x => x.TotalPlayers)
				.ThenBy(x => x.Id)
				.ToArray();

			var json = JsonConvert.SerializeObject(result, Formatting.Indented);

			return json;
		}

		public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
		{
			StringBuilder sb = new StringBuilder();

			XmlRootAttribute xmlRoot = new XmlRootAttribute("Users");
			XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
			namespaces.Add(string.Empty, string.Empty);

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(UserOutputModel[]), xmlRoot);

			using StringWriter stringWriter = new StringWriter(sb);

            PurchaseType purchaseTypeEnum = Enum.Parse<PurchaseType>(storeType);

            var users = context
                .Users
                .ToArray()
                .Where(u => u.Cards.Any(c => c.Purchases.Any()))
                .Select(u => new UserOutputModel()
                {
                    Username = u.Username,
                    Purchases = context
                        .Purchases
                        .ToArray()
                        .Where(p => p.Card.User.Username == u.Username && p.Type == purchaseTypeEnum)
                        .OrderBy(p => p.Date)
                        .Select(p => new PurchaseOutputModel()
                        {
                            CardNumber = p.Card.Number,
                            Cvc = p.Card.Cvc,
                            Date = p.Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                            Game = new GameOutputModel()
                            {
                                Name = p.Game.Name,
                                Genre = p.Game.Genre.Name,
                                Price = p.Game.Price
                            }
                        })
                        .ToArray(),
                    TotalSpent = context
                        .Purchases
                        .ToArray()
                        .Where(p => p.Card.User.Username == u.Username && p.Type == purchaseTypeEnum)
                        .Sum(p => p.Game.Price)
                })
                .Where(u => u.Purchases.Length > 0)
                .OrderByDescending(u => u.TotalSpent)
                .ThenBy(u => u.Username)
                .ToArray();

            xmlSerializer.Serialize(stringWriter, users, namespaces);

			return sb.ToString().Trim();
		}
	}
}