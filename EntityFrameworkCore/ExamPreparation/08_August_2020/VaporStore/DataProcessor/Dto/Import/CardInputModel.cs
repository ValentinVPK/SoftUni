using System.ComponentModel.DataAnnotations;
using VaporStore.Common;
using VaporStore.Data.Models.Enums;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class CardInputModel
    {
        [Required]
        [RegularExpression(GlobalConstants.CARD_NUMBER_REGEX)]
        public string Number { get; set; }

        [Required]
        [RegularExpression(GlobalConstants.CARD_CVC_REGEX)]
        public string CVC { get; set; }

        [Required]
        [EnumDataType(typeof(CardType))]
        public string Type { get; set; }
    }

    /*"Number": "1111 1111 1111 1111",
				"CVC": "111",
				"Type": "Debit"*/
}