using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using Theatre.Common;

namespace Theatre.DataProcessor.ImportDto
{
    [XmlType("Cast")]
    public class CastInputModel
    {
        [XmlElement("FullName")]
        [StringLength(GlobalConstants.CAST_FULLNAME_MAX_LENGTH, MinimumLength = GlobalConstants.CAST_FULLNAME_MIN_LENGTH)]
        [Required]
        public string FullName { get; set; }

        [XmlElement("IsMainCharacter")]
        public bool IsMainCharacter { get; set; } // could give an error

        [XmlElement("PhoneNumber")]
        [RegularExpression(GlobalConstants.CAST_PHONE_NUMBER_REGEX)]
        [Required]
        public string PhoneNumber { get; set; }

        [XmlElement("PlayId")]
        public int PlayId { get; set; }
    }

    /*<Cast>
    <FullName>Van Tyson</FullName>
    <IsMainCharacter>false</IsMainCharacter>
    <PhoneNumber>+44-35-745-2774</PhoneNumber>
    <PlayId>26</PlayId>
  </Cast>*/
}
