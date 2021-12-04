namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";

        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Plays");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PlayInputModel[]), xmlRoot);

            using StringReader stringReader = new StringReader(xmlString);

            PlayInputModel[] playInputModels = (PlayInputModel[])xmlSerializer.Deserialize(stringReader);

            HashSet<Play> validPlays = new HashSet<Play>();

            foreach (var playModel in playInputModels)
            {
                if(!IsValid(playModel))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var isValidTimeSpan = TimeSpan.TryParseExact(playModel.Duration, "c", CultureInfo.InvariantCulture, TimeSpanStyles.None, out TimeSpan duration);

                if(!isValidTimeSpan)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if(duration.Hours < 1)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Play play = new Play()
                {
                    Title = playModel.Title,
                    Duration = duration,
                    Rating = playModel.Rating,
                    Genre = Enum.Parse<Genre>(playModel.Genre),
                    Description = playModel.Description,
                    Screenwriter = playModel.Screenwriter
                };

                validPlays.Add(play);
                sb.AppendLine(String.Format(SuccessfulImportPlay, play.Title, play.Genre.ToString(), play.Rating));
            }

            context.AddRange(validPlays);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Casts");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CastInputModel[]), xmlRoot);

            using StringReader stringReader = new StringReader(xmlString);

            CastInputModel[] castInputModels = (CastInputModel[])xmlSerializer.Deserialize(stringReader);

            HashSet<Cast> validCasts = new HashSet<Cast>();

            foreach (var castModel in castInputModels)
            {
                if(!IsValid(castModel))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Cast cast = new Cast()
                {
                    FullName = castModel.FullName,
                    IsMainCharacter = castModel.IsMainCharacter,
                    PhoneNumber = castModel.PhoneNumber,
                    PlayId = castModel.PlayId
                };

                string actorRole = cast.IsMainCharacter ? "main" : "lesser";

                validCasts.Add(cast);
                sb.AppendLine(String.Format(SuccessfulImportActor, cast.FullName, actorRole));
            }

            context.AddRange(validCasts);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var theatreModels = JsonConvert.DeserializeObject<IEnumerable<TheatreInputModel>>(jsonString);

            HashSet<Theatre> validTheatres = new HashSet<Theatre>();

            foreach (var theatreModel in theatreModels)
            {
                if(!IsValid(theatreModel))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Theatre theatre = new Theatre()
                {
                    Name = theatreModel.Name,
                    NumberOfHalls = theatreModel.NumberOfHalls,
                    Director = theatreModel.Director,
                };

                HashSet<Ticket> validTickets = new HashSet<Ticket>();
                foreach (var ticketModel in theatreModel.Tickets)
                {
                    if(!IsValid(ticketModel))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    /*if(!context.Plays.Any(p => p.Id == ticketModel.PlayId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }*/

                    Ticket ticket = new Ticket()
                    {
                        Price = ticketModel.Price,
                        RowNumber = ticketModel.RowNumber,
                        PlayId = ticketModel.PlayId
                    };

                    validTickets.Add(ticket);
                }

                theatre.Tickets = validTickets;
                //context.AddRange(validTickets);
                //context.SaveChanges();
                validTheatres.Add(theatre);
                sb.AppendLine(String.Format(SuccessfulImportTheatre, theatre.Name, theatre.Tickets.Count));
            }

            context.AddRange(validTheatres);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }


        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
