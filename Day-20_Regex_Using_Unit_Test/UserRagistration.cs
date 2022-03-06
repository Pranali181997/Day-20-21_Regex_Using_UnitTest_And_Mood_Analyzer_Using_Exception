using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class UserRagistration
    {

        public static string REGEX_NAME = "^[A-Z]{1}[a-z]{1,}$";


        public bool validateName(string Name)
        {
            return Regex.IsMatch(Name, REGEX_NAME);
        }
    }
}
