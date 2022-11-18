﻿
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using System;

namespace Day_21_Practice_User_Registration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome TO Day 21 assingment Problem");
            Console.WriteLine("Hello User please Enter the First Name");
            Console.WriteLine(" NOTE:- First name starts with Cap and haS nminimum 3 characters");
            
                
                UserRegistration userRegistration = new UserRegistration();

                try {
                string userdata = Console.ReadLine();
                bool value = userRegistration.validatename(userdata);
               

                if (value)
                {
                    Console.WriteLine("Given Name Accepted");

                }
                else
                {
                    throw new InvalidNameException("Please Enter Valid Name");
                   
                }
            }
            catch (InvalidNameException n)
            {
                Console.WriteLine(n);
            }

            try
            {
                Console.WriteLine("Enter Last Name");
                Console.WriteLine("NOTE:- Last name starts with Cap and has minimum 3 characters");

                string userlastname = Console.ReadLine();

                bool value = userRegistration.validatelastname(userlastname);

                if (value)
                {
                    Console.WriteLine("Given Last Name Accepted");
                }
                else
                {
                    throw new InvalidLastNameException("Please Enter Valid Last Name");

                }
            }
            catch (InvalidLastNameException l)
            {
                Console.WriteLine(l);
            }

            try
            {
                Console.WriteLine("Enter Mail ID");
                Console.WriteLine("NOTE:- E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl&co) and 2 optional (xyz & in) with\r\nprecise @ and . positions");

                string usermail = Console.ReadLine();

                bool value = userRegistration.validatemail(usermail);

                if (value)
                {
                    Console.WriteLine("Given Mail ID  Accepted");
                }
                else
                {
                    throw new InvalidEmailException("Please Enter Valid Mail ID");
                    
                }
            }
            catch(InvalidEmailException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}