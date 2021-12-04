using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using Theatre.Common;
using Theatre.Data.Models.Enums;

namespace Theatre.DataProcessor.ImportDto
{
    [XmlType("Play")]
    public class PlayInputModel
    {
        [XmlElement("Title")]
        [Required]
        [StringLength(GlobalConstants.PLAY_TITLE_MAX_LENGTH, 
            MinimumLength = GlobalConstants.PLAY_TITLE_MIN_LENGTH)]
        public string Title { get; set; }

        [XmlElement("Duration")]
        [Required]
        public string Duration { get; set; }
        
        [XmlElement("Rating")]
        [Range(typeof(float), "0", "10")]
        public float Rating { get; set; }

        [XmlElement("Genre")]
        [Required]
        [EnumDataType(typeof(Genre))]
        public string Genre { get; set; }

        [XmlElement("Description")]
        [StringLength(GlobalConstants.PLAY_DESCRIPTION_MAX_LENGTH, 
            MinimumLength = GlobalConstants.PLAY_DESCRIPTION_MIN_LENGTH)]
        [Required]
        public string Description { get; set; }

        [XmlElement("Screenwriter")]
        [StringLength(GlobalConstants.PLAY_SCREENWRITER_MAX_LENGTH, 
            MinimumLength = GlobalConstants.PLAY_SCREENWRITER_MIN_LENGTH)]
        [Required]
        public string Screenwriter { get; set; }
    }

    /*<Play>
    <Title>The Hsdfoming</Title>
    <Duration>03:40:00</Duration>
    <Rating>8.2</Rating>
    <Genre>Action</Genre>
    <Description>A guyat Pinter turns into a debatable conundrum as oth ordinary and menacing. Much of this has to do with the fabled "Pinter Pause," which simply mirrors the way we often respond to each other in conversation, tossing in remainders of thoughts on one subject well after having moved on to another.</Description>
    <Screenwriter>Roger Nciotti</Screenwriter>
  </Play>*/

}
