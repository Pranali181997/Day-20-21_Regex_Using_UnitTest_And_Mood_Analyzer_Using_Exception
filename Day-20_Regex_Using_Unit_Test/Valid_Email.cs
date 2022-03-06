using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class Valid_Email
    {
        //public static string REGEX_EMAIL = "^[a-z]{2,}(.[a-z]{1,})?@[a-z]{2,}.[a-z]{2,}(.[a-z]{2})?(.[a-z]{1,})?(.[a-z]{1,})?$";
        public static string REGEX_EMAIL = "^[a-z]{2,}(.[a-z]{1,})?@[a-z]{1,}.[a-z]{1,}.[a-z]{1,}$";

        public bool validEmail(string Email)
        {
            return Regex.IsMatch(Email, REGEX_EMAIL); //"abc.xyz@bl.co.in"
        }
    }
}
