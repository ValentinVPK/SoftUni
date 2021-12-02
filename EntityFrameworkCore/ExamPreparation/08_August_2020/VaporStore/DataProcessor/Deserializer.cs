namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Common;
    using VaporStore.Data.Models;
    using VaporStore.Data.Models.Enums;
    using VaporStore.DataProcessor.Dto.Import;

    public static class Deserializer
	{
		public static string ImportGames(VaporStoreDbContext context, string jsonString)
		{
			StringBuilder sb = new StringBuilder();

			var gamesDtos = JsonConvert.DeserializeObject<IEnumerable<GameInputModel>>(jsonString);

			HashSet<Game> validGames = new HashSet<Game>();

            foreach (var game in gamesDtos)
            {
				if(!IsValid(game)
					|| game.Tags.Length == 0)
                {
					sb.AppendLine(GlobalConstants.ERROR_MESSAGE);
					continue;
                }

				if(!context.Developers.Any(d => d.Name == game.Developer))
                {
					Developer dev = new Developer
					{
						Name = game.Developer
					};

					context.Developers.Add(dev);
                }

				if(!context.Genres.Any(g => g.Name == game.Genre))
                {
					Genre genre = new Genre
					{
						Name = game.Genre
					};

					context.Genres.Add(genre);
                }

                foreach (var tagName in game.Tags)
                {
					if(!context.Tags.Any(t => t.Name == tagName))
                    {
						Tag tag = new Tag
						{
							Name = tagName
						};

						context.Tags.Add(tag);
                    }
                }

				context.SaveChanges();

				var releaseDate = DateTime.ParseExact(game.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

				Game validGame = new Game
				{
					Name = game.Name,
					Price = game.Price,
					ReleaseDate = releaseDate,
					DeveloperId = context.Developers.First(x => x.Name == game.Developer).Id,
					GenreId = context.Genres.First(x => x.Name == game.Genre).Id,
					GameTags = game.Tags.Select(x => new GameTag
					{
						TagId = context.Tags.First(t => t.Name == x).Id
					})
					.ToList()
				};

				validGames.Add(validGame);
				sb.AppendLine
					($"Added {game.Name} ({game.Genre}) with {game.Tags.Length} tags");
            }

			context.AddRange(validGames);
			context.SaveChanges();
			return sb.ToString().Trim();
		}

		public static string ImportUsers(VaporStoreDbContext context, string jsonString)
		{
			StringBuilder sb = new StringBuilder();

			var userDtos = JsonConvert.DeserializeObject<IEnumerable<UserInputModel>>(jsonString);

			HashSet<User> validUsers = new HashSet<User>();

            foreach (var userDto in userDtos)
            {
				if(!IsValid(userDto) 
					|| !userDto.Cards.All(IsValid)
					|| userDto.Cards.Length == 0)
                {
					sb.AppendLine(GlobalConstants.ERROR_MESSAGE);
					continue;
                }

				User user = new User
				{
					FullName = userDto.FullName,
					Username = userDto.Username,
					Age = userDto.Age,
					Email = userDto.Email,
					Cards = userDto.Cards.Select(x => new Card
					{
						Number = x.Number,
						Cvc = x.CVC,
						Type = Enum.Parse<CardType>(x.Type)
					})
					.ToList()
				};

				validUsers.Add(user);
				sb.AppendLine($"Imported {userDto.Username} with {userDto.Cards.Length} cards");
            }

			context.AddRange(validUsers);
			context.SaveChanges();

			return sb.ToString().Trim();
		}

		public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
		{
			StringBuilder sb = new StringBuilder();

			XmlRootAttribute xmlRoot = new XmlRootAttribute("Purchases");
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(PurchaseInputModel[]), xmlRoot);

			using StringReader stringReader = new StringReader(xmlString);

			PurchaseInputModel[] purchaseDtos = (PurchaseInputModel[])xmlSerializer.Deserialize(stringReader);

			HashSet<Purchase> validPurchases = new HashSet<Purchase>();

            foreach (var purchaseDto in purchaseDtos)
            {
				if (!IsValid(purchaseDto))
                {
					sb.AppendLine(GlobalConstants.ERROR_MESSAGE);
					continue;
                }

				var date = DateTime.ParseExact(purchaseDto.Date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

				Purchase purchase = new Purchase
				{
					ProductKey = purchaseDto.ProductKey,
					Type = Enum.Parse<PurchaseType>(purchaseDto.Type),
					Date = date,
					Game = context.Games.First(x => x.Name == purchaseDto.GameName),
					Card = context.Cards.First(x => x.Number == purchaseDto.CardNumber)
				};

				validPurchases.Add(purchase);
				sb.AppendLine($"Imported {purchaseDto.GameName} for {purchase.Card.User.Username}");
            }

			context.AddRange(validPurchases);
			context.SaveChanges();

			return sb.ToString().Trim();
		}

		private static bool IsValid(object dto)
		{
			var validationContext = new ValidationContext(dto);
			var validationResult = new List<ValidationResult>();

			return Validator.TryValidateObject(dto, validationContext, validationResult, true);
		}
	}
}