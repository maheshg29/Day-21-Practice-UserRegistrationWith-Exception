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
}


