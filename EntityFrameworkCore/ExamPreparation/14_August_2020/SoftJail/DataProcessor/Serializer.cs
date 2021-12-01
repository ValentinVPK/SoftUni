namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.DataProcessor.ExportDto;
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportPrisonersByCells(SoftJailDbContext context, int[] ids)
        {
            var result = context.Prisoners
                .Where(x => ids.Contains(x.Id))
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.FullName,
                    CellNumber = x.Cell.CellNumber,
                    Officers = x.PrisonerOfficers.Select(o => new
                    {
                        OfficerName = o.Officer.FullName,
                        Department = o.Officer.Department.Name
                    })
                    .OrderBy(x => x.OfficerName)
                    .ToList(),
                    TotalOfficerSalary = decimal.Parse(x.PrisonerOfficers
                    .Sum(x => x.Officer.Salary)
                    .ToString("F2")),
                })
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Id)
                .ToList();

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return json;
        }

        public static string ExportPrisonersInbox(SoftJailDbContext context, string prisonersNames)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Prisoners");
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PrisonerOutputModel[]), xmlRoot);

            using StringWriter stringWriter = new StringWriter(sb);

            var names = prisonersNames.Split(',', StringSplitOptions.RemoveEmptyEntries);

            PrisonerOutputModel[] result = context
                .Prisoners
                .Where(p => names.Contains(p.FullName))
                .Select(x => new PrisonerOutputModel
                {
                    Id = x.Id,
                    Name = x.FullName,
                    IncarcerationDate = x.IncarcerationDate.ToString("yyyy-MM-dd"),
                    EncryptedMessages = x.Mails.Select(m => new EncryptedMessageOutputModel
                    {
                        Description = string.Join("", m.Description.Reverse())
                    })
                    .ToArray()
                })
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Id)
                .ToArray();


            xmlSerializer.Serialize(stringWriter, result, namespaces);

            return sb.ToString().Trim();
        }
    }
}