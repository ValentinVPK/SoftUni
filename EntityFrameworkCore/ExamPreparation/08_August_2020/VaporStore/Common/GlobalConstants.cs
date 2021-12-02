using System;
using System.Collections.Generic;
using System.Text;

namespace VaporStore.Common
{
    public static class GlobalConstants
    {
        //Game

        //Card
        public const string CARD_NUMBER_REGEX = @"\d{4} \d{4} \d{4} \d{4}";
        public const string CARD_CVC_REGEX = @"\d{3}";

        //User
        public const int USERNAME_MIN_LENGTH = 3;
        public const int USERNAME_MAX_LENGTH = 20;
        public const string USER_FULLNAME_REGEX = @"[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+";
        public const int USER_MIN_AGE = 3;
        public const int USER_MAX_AGE = 103;

        //Purchase

        public const string PURCHASE_KEY_REGEX = @"[A-Z\d]{4}-[A-Z\d]{4}-[A-Z\d]{4}";

        //Messages
        public const string ERROR_MESSAGE = "Invalid Data";
        

    }
}
