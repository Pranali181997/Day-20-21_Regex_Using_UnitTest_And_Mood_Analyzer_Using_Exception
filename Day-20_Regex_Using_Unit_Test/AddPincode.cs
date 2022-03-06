using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class AddPincode
    {

        public string REGEX_code = "^[1-9]{1}[0-9]{5}$"; //UC-1,2,3 

        //public static string REGEX_PINCODE ="^[1-9][0-9]{2}\\s[0-9]{3}$"; //UC-4


        public bool validatepin(string Pincode)
        {
            return Regex.IsMatch(Pincode, REGEX_code);
        }
    }
}
