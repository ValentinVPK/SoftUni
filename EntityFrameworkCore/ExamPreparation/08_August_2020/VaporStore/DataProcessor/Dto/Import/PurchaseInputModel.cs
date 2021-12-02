using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using VaporStore.Common;
using VaporStore.Data.Models.Enums;

namespace VaporStore.DataProcessor.Dto.Import
{
    [XmlType("Purchase")]
    public class PurchaseInputModel
    {
        [XmlAttribute("title")]
        [Required]
        public string GameName { get; set; }

        [XmlElement("Type")]
        [Required]
        [EnumDataType(typeof(PurchaseType))]
        public string Type { get; set; }

        [XmlElement("Key")]
        [Required]
        [RegularExpression(GlobalConstants.PURCHASE_KEY_REGEX)]
        public string ProductKey { get; set; }

        [XmlElement("Card")]
        [Required]
        [RegularExpression(GlobalConstants.CARD_NUMBER_REGEX)]
        public string CardNumber { get; set; }

        [XmlElement("Date")]
        [Required]
        public string Date { get; set; }
    }

    /*<Purchase title = "Dungeon Warfare 2" >
    < Type > Digital </ Type >
    < Key > ZTZ3 - 0D2S-G4TJ</Key>
    <Card>1833 5024 0553 6211</Card>
    <Date>07/12/2016 05:49</Date>
    </Purchase>*/
}
