namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.DataProcessor.ExportDto;

    public class Serializer
    {
        public static string ExportTheatres(TheatreContext context, int numbersOfHalls)
        {
            var result = context.Theatres
                .ToArray()
                .Where(t => t.NumberOfHalls >= numbersOfHalls && t.Tickets.Count >= 20)
                .Select(x => new
                {
                    Name = x.Name,
                    Halls = x.NumberOfHalls,
                    TotalIncome = x.Tickets.Where(ti => ti.RowNumber >= 1 && ti.RowNumber <= 5).Sum(ti => ti.Price),
                    Tickets = x.Tickets
                    .Where(ti => ti.RowNumber >= 1 && ti.RowNumber <= 5)
                    .Select(y => new
                    {
                        Price = y.Price,
                        RowNumber = y.RowNumber // could be different
                    })
                    .OrderByDescending(y => y.Price)
                    .ToArray()
                })
                .OrderByDescending(x => x.Halls)
                .ThenBy(x => x.Name)
                .ToArray();

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return json;
        }
        

        public static string ExportPlays(TheatreContext context, double rating)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Plays");
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PlayOutputModel[]), xmlRoot);

            using StringWriter stringWriter = new StringWriter(sb);

            PlayOutputModel[] result = context.Plays
                .ToArray()
                .Where(x => x.Rating <= rating)
                .Select(x => new PlayOutputModel()
                {
                    Title = x.Title,
                    Duration = x.Duration.ToString("c", CultureInfo.InvariantCulture),
                    Rating = x.Rating == 0 ? "Premier" : x.Rating.ToString(),
                    Genre = x.Genre.ToString(),
                    Actors = x.Casts.Where(x => x.IsMainCharacter).Select(c => new ActorOutputModel()
                    {
                        FullName = c.FullName,
                        MainCharacter = $"Plays main character in \'{x.Title}\'."
                    })
                    .OrderByDescending(a => a.FullName)
                    .ToArray()
                })
                .OrderBy(x => x.Title)
                .ThenByDescending(x => x.Genre)
                .ToArray();

            xmlSerializer.Serialize(stringWriter, result, namespaces);

            return sb.ToString().TrimEnd();
        }

        /*Use the method provided in the project skeleton, which receives a rating.Export all plays with a rating equal or smaller to the given.For each play, export Title, Duration (in the format: "c"), Rating, Genre, and Actors which play the main character only.
        Keep in mind:
        •	If the rating is 0, you should print "Premier". 
        •	For each actor display:
        o FullName
        o MainCharacter in the format: "Plays main character in '{playTitle}'."
        Order the result by play title (ascending), then by genre (descending). Order actors by their full name      descending.*/
        
    }
}
