using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    public class PassUC_5
    {
        public static string REGEX_Password = "^[A-Za-z0-9]{8,}$";
        
        public bool validPassword(string Password)
        {
            return Regex.IsMatch(Password, REGEX_Password);
        }
    }
}
