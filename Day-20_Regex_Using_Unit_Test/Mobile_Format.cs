using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    public class Mobile_Format
    {
        public static string REGEX_MOBILE = "^[/+]{1}[9]{1}[1]{1}[7-9]{1}[0-9]{9}$";
        //public static string REGEX_MOBILE = (@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
        public bool validMobile(string Mobile)  
        {
            return Regex.IsMatch(Mobile, REGEX_MOBILE);
        }
    }
}
