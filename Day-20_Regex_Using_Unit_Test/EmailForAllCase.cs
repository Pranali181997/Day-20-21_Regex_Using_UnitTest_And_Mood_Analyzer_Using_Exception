using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    public class EmailForAllCase
    {
        public static string REGEX_EMAIL = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        //public static string REGEX_EMAIL = "^[a-z]{3,}(([.+]{1})?{[-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";

        //public static string REGEX_EMAIL = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3})?$";


        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, REGEX_EMAIL);
        }
    }
}
