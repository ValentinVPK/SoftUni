using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Theatre.Common;

namespace Theatre.DataProcessor.ImportDto
{
    public class TheatreInputModel
    {
        [StringLength(GlobalConstants.THEATRE_NAME_MAX_LENGTH, 
            MinimumLength = GlobalConstants.THEATRE_NAME_MIN_LENGTH)]
        [Required]
        public string Name { get; set; }

        [Range(GlobalConstants.THEATRE_MIN_HALLS, GlobalConstants.THEATRE_MAX_HALLS)]
        public sbyte NumberOfHalls { get; set; } // could be changed to int later

        [StringLength(GlobalConstants.THEATRE_DIRECTOR_MAX_LENGTH,
            MinimumLength = GlobalConstants.THEATRE_DIRECTOR_MIN_LENGTH)]
        [Required]
        public string Director { get; set; }

        public ICollection<TicketInputModel> Tickets { get; set; }
    }

   /* {
    "Name": "",
    "NumberOfHalls": 7,
    "Director": "Ulwin Mabosty",
    "Tickets": [
      {
        "Price": 7.63,
        "RowNumber": 5,
        "PlayId": 4
      },
      {
    "Price": 47.96,
        "RowNumber": 9,
        "PlayId": 3
      }
    ]
  },*/
}
