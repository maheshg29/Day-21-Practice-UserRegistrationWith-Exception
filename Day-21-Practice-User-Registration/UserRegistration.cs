using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21_Practice_User_Registration
{
    public class UserRegistration
    {
        public static string REGEX_NAME = "^[A-Z]{1}[a-z]{2}[a-z]*";
        //this function is use for NAME validate
        public bool validatename(string userdata)
        {
            return Regex.IsMatch(userdata, REGEX_NAME);
        }

        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{2}[a-z]*";
        //this function is use for LAST NAME validate
        public bool validatelastname(string userdata)
        {
            return Regex.IsMatch(userdata, REGEX_LASTNAME);
        }
    }
}
