using SoftJail.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    public class PrisonerMailInputModel
    {

        [Required]
        [StringLength(GlobalConstants.PRISONER_FULLNAME_MAX_LENGTH, MinimumLength =GlobalConstants.PRISONER_FULLNAME_MIN_LENGTH)]
        public string FullName { get; set; }

        [Required]
        [RegularExpression(GlobalConstants.PRISONER_NICKNAME_REGEX)]
        public string Nickname { get; set; }

        [Range(GlobalConstants.PRISONER_MIN_AGE, GlobalConstants.PRISONER_MAX_AGE)]
        public int Age { get; set; }


        public string IncarcerationDate { get; set; }

        public string ReleaseDate { get; set; }


        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal? Bail { get; set; }

        public int? CellId { get; set; }

        public ICollection<MailInputModel> Mails { get; set; }
    }

  /*  {
    "FullName": "",
    "Nickname": "The Wallaby",
    "Age": 32,
    "IncarcerationDate": "29/03/1957",
    "ReleaseDate": "27/03/2006",
    "Bail": null,
    "CellId": 5,
    "Mails": [
      {
        "Description": "Invalid FullName",
        "Sender": "Invalid Sender",
        "Address": "No Address"
      },
      {
    "Description": "Do not put this in your code",
        "Sender": "My Ansell",
        "Address": "ha-ha-ha"
      }
    ]
  },*/
}
