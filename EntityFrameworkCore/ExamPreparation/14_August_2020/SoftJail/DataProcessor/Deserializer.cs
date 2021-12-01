namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.Common;
    using SoftJail.Data.Models;
    using SoftJail.Data.Models.Enums;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {
        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var departmentsCells = JsonConvert.DeserializeObject<IEnumerable<DepartmentCellInputModel>>(jsonString);

            HashSet<Department> departments = new HashSet<Department>();
            foreach (var departmentCell in departmentsCells)
            {
                if(!IsValid(departmentCell) || 
                    departmentCell.Cells.Count == 0 ||
                    !departmentCell.Cells.All(IsValid))
                {
                    sb.AppendLine(GlobalConstants.ERROR_MESSAGE);
                    continue;
                }

                Department d = new Department
                {
                    Name = departmentCell.Name,
                    Cells = departmentCell.Cells.Select(x => new Cell
                    {
                        CellNumber = x.CellNumber,
                        HasWindow = x.HasWindow
                    })
                    .ToList()
                };

                departments.Add(d);
                sb.AppendLine($"Imported {d.Name} with {d.Cells.Count} cells");
            }

            context.AddRange(departments);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var prisonerMails = JsonConvert.DeserializeObject<IEnumerable<PrisonerMailInputModel>>(jsonString);
            var prisoners = new HashSet<Prisoner>();
            foreach (var prisoner in prisonerMails)
            {
                if(!IsValid(prisoner) || !prisoner.Mails.All(IsValid))
                {
                    sb.AppendLine(GlobalConstants.ERROR_MESSAGE);
                    continue;
                }

                var isValidReleaseDate = DateTime.TryParseExact(prisoner.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime releaseDate);

                var incarcerationDate = DateTime.ParseExact(prisoner.IncarcerationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                var prisonerModel = new Prisoner
                {
                    FullName = prisoner.FullName,
                    Nickname = prisoner.Nickname,
                    Age = prisoner.Age,
                    Bail = prisoner.Bail,
                    CellId = prisoner.CellId,
                    ReleaseDate = isValidReleaseDate ? (DateTime?)releaseDate : null,
                    IncarcerationDate = incarcerationDate,
                    Mails = prisoner.Mails.Select(m => new Mail
                    {
                        Sender = m.Sender,
                        Description = m.Description,
                        Address = m.Address
                    })
                    .ToList()
                };

                prisoners.Add(prisonerModel);
                sb.AppendLine($"Imported {prisonerModel.FullName} {prisonerModel.Age} years old");
            }

            context.AddRange(prisoners);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Officers");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OfficerWithPrisonersInputModel[]), xmlRoot);

            using StringReader stringReader = new StringReader(xmlString);

            OfficerWithPrisonersInputModel[] officerWithPrisonersInputModels = (OfficerWithPrisonersInputModel[])xmlSerializer.Deserialize(stringReader);

            HashSet<Officer> officers = new HashSet<Officer>();

            foreach (var officerPrisoner in officerWithPrisonersInputModels)
            {
                if(!IsValid(officerPrisoner))
                {
                    sb.AppendLine(GlobalConstants.ERROR_MESSAGE);
                    continue;
                }

                Officer officer = new Officer
                {
                    FullName = officerPrisoner.Name,
                    Salary = officerPrisoner.Money,
                    DepartmentId = officerPrisoner.DepartmentId,
                    Position = Enum.Parse<Position>(officerPrisoner.Position),
                    Weapon = Enum.Parse<Weapon>(officerPrisoner.Weapon),
                    OfficerPrisoners = officerPrisoner.Prisoners.Select(p => new OfficerPrisoner
                    {
                        PrisonerId = p.Id,
                    })
                    .ToList()
                };

                officers.Add(officer);
                sb.AppendLine($"Imported {officer.FullName} ({officer.OfficerPrisoners.Count} prisoners)");
            }

            context.AddRange(officers);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);
            return isValid;
        }
    }
}