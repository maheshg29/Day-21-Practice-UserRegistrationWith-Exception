using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_21_Practice_User_Registration
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message)
        {
            Console.WriteLine("Please Enter valid Name ");
        }
    }

    public class InvalidLastNameException : Exception
    {
        public InvalidLastNameException(string message) : base(message)
        {
            Console.WriteLine("Please Enter valid Name ");
        }
    }

    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message)
        {
            Console.WriteLine("Please Enter valid Email ID ");
        }
    }

    public class ValidMobileNumberException : Exception
    {
        public ValidMobileNumberException(string message) : base(message)
        {
            Console.WriteLine("Please Enter valid Mobile Number");
        }
    }
}


