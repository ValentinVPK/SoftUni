using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace JsonDermo
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car
            {
                Extras = new List<string> { "Klimatronik", "4x4", "Farove" },
                ManufacturedOn = DateTime.Now,
                Model = "Golf",
                Vendor = "VW",
                Price = 12345.67M,
                Engine = new Engine { Volume = 1.6f, HorsePower = 80}
            };


            //System.Text.Json

            /*var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };*/

            //Console.WriteLine(JsonSerializer.Serialize(car, options));

         
            //Car car = JsonSerializer.Deserialize<Car>(json);



            //Newtonsoft.JSON

            //var json = File.ReadAllText("myCar.json");
            //Console.WriteLine(JsonConvert.SerializeObject(new { Name = "Niki", Course = "EF Core" }));

            //var car = JsonConvert.DeserializeObject<Car>(json);

            //EDIT - PASTE SPECIAL

            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy(),
                },
                DateFormatString = "yyyy-MM-dd",
                
            };

            Console.WriteLine(JsonConvert.SerializeObject(car, options));
            //Console.WriteLine(JsonConvert.SerializeObject(new { Car = car, Name = "Niki"}));

            var json = File.ReadAllText("myCar.json");
            var car2 = JsonConvert.DeserializeObject<Car>(json);

            var jObject = JObject.Parse(json);

            var xmlDoc = JsonConvert.DeserializeXmlNode(json);
        }
    }
}
