using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.DataTransferObjects.Input
{
    [XmlType("partId")]
    public class CarPartInputModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
