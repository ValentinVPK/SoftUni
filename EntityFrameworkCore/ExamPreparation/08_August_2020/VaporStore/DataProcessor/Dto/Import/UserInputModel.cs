using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VaporStore.Common;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class UserInputModel
    {
		[Required]
		[RegularExpression(GlobalConstants.USER_FULLNAME_REGEX)]
		public string FullName { get; set; }

		[Required]
		[StringLength(GlobalConstants.USERNAME_MAX_LENGTH, MinimumLength = GlobalConstants.USERNAME_MIN_LENGTH)]
        public string Username { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Range(GlobalConstants.USER_MIN_AGE, GlobalConstants.USER_MAX_AGE)]
		public int Age { get; set; }

		[Required]
        public CardInputModel[] Cards { get; set; }
    }

    /*{
		"FullName": "",
		"Username": "invalid",
		"Email": "invalid@invalid.com",
		"Age": 20,
		"Cards": [
			{
				"Number": "1111 1111 1111 1111",
				"CVC": "111",
				"Type": "Debit"
			}
		]
	},*/
}
