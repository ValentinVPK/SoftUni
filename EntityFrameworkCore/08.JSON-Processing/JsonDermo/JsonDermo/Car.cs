using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDermo
{
    public class Car
    {
        public string Model { get; set; }

        [JsonProperty(Order = 10, PropertyName = "Brand")]
        public string Vendor { get; set; }

        public decimal Price { get; set; }

        public DateTime ManufacturedOn { get; set; }

        [JsonIgnore]
        public List<string> Extras { get; set; }

        public Engine Engine { get; set; }
    }
}
