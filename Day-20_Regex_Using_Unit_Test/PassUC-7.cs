using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    public class PassUC_7
    {
        public static string REGEX_Password = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z]).*$";

        public bool validPasswordRule3(string Password)
        {
            return Regex.IsMatch(Password, REGEX_Password);
        }

    }
}
