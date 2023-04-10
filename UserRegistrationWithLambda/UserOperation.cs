﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationWithLambda
{
    public class UserOperation
    {
        public const string NAME = "^[A-Z]{1}[a-z]{2,}$";
        public const string EMAIL = "^[a-zA-Z]{3,}[.]{0,1}[a-zA-Z]{0,}[@]{1}[a-zA-Z]{2,}[.]{1}[a-zA-Z]{2,3}[.]{0,1}[a-zA-Z]{0,2}$";
        public const string MOBILE_NUMBER = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public const string PASSWORD = "^[A-Z]{1,}[a-z]{3,}[0-9]{1,}$";
        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, NAME))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidateEmail(string eMail)
        {
            if (Regex.IsMatch(eMail, EMAIL))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatePhoneNumber(string number)
        {
            if (Regex.IsMatch(number, MOBILE_NUMBER))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatePasswordRule3(string passwd)
        {
            if (Regex.IsMatch(passwd, PASSWORD))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
