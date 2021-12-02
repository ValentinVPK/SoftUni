﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace VaporStore.DataProcessor.Dto.Export
{
    [XmlType("Game")]
    public class GameOutputModel
    {
        [XmlAttribute("title")]
        public string Name { get; set; }

        [XmlElement("Genre")]
        public string Genre { get; set; }

        [XmlElement("Price")]
        public decimal Price { get; set; }
    }

    /*<Game title = "Counter-Strike: Global Offensive" >
          < Genre > Action </ Genre >
          < Price > 12.49 </ Price >
        </ Game >*/
}
