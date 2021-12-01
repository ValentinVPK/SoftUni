using System;
using System.Collections.Generic;
using System.Text;

namespace SoftJail.Common
{
    public static class GlobalConstants
    {
        //Prisoner
        public const int PRISONER_FULLNAME_MIN_LENGTH = 3;
        public const int PRISONER_FULLNAME_MAX_LENGTH = 20;
        public const string PRISONER_NICKNAME_REGEX = @"The [A-Z]{1}[a-z]+";
        public const int PRISONER_MIN_AGE = 18;
        public const int PRISONER_MAX_AGE = 65;

        //Officer

        public const int OFFICER_NAME_MIN_LENGTH = 3;
        public const int OFFICER_NAME_MAX_LENGTH = 30;

        //Department

        public const int DEPARTMENT_NAME_MIN_LENGTH = 3;
        public const int DEPARTMENT_NAME_MAX_LENGTH = 25;

        //Cell
        public const int CELL_MIN_RANGE = 1;
        public const int CELL_MAX_RANGE = 1000;

        //Mail

        public const string MAIL_ADDRESS_REGEX = @"^([0-9\sA-Za-z]+ str.)$";

        //Messages
        public const string ERROR_MESSAGE = "Invalid Data";
        public const string SUCCESS_MESSAGE = "Imported {departmentName} with {cellsCount} cells";
        public const string SUCCESS_PRISONER_MESSAGE = "Imported {prisonerName} {prisonerAge} years old";
    }
}
