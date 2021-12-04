using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Theatre.Common;

namespace Theatre.DataProcessor.ImportDto
{
    public class TicketInputModel
    {
        [Range(typeof(decimal), "1", "100")]
        public decimal Price { get; set; } // could be changed to double

        [Range(GlobalConstants.TICKET_MIN_ROW_NUMBER, GlobalConstants.TICKET_MAX_ROW_NUMBER)]
        public sbyte RowNumber { get; set; } // could be changed to int

        public int PlayId { get; set; }
    }

    /*"Price": 7.63,
        "RowNumber": 5,
        "PlayId": 4*/
}
