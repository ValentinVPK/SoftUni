﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Theatre.Common
{
    public static class GlobalConstants
    {
        //Play
        public const int PLAY_TITLE_MIN_LENGTH = 4;
        public const int PLAY_TITLE_MAX_LENGTH = 50;
        public const int PLAY_DESCRIPTION_MIN_LENGTH = 0;
        public const int PLAY_DESCRIPTION_MAX_LENGTH = 700;
        public const int PLAY_SCREENWRITER_MIN_LENGTH = 4;
        public const int PLAY_SCREENWRITER_MAX_LENGTH = 30;

        //Cast

        public const int CAST_FULLNAME_MIN_LENGTH = 4;
        public const int CAST_FULLNAME_MAX_LENGTH = 30;
        public const string CAST_PHONE_NUMBER_REGEX = @"\+44\-\d{2}\-\d{3}\-\d{4}";

        //Theater

        public const int THEATRE_NAME_MIN_LENGTH = 4;
        public const int THEATRE_NAME_MAX_LENGTH = 30;
        public const int THEATRE_MIN_HALLS = 1;
        public const int THEATRE_MAX_HALLS = 10;
        public const int THEATRE_DIRECTOR_MIN_LENGTH = 4;
        public const int THEATRE_DIRECTOR_MAX_LENGTH = 30;

        //Ticket

        public const int TICKET_MIN_ROW_NUMBER = 1;
        public const int TICKET_MAX_ROW_NUMBER = 10;
    }
}
