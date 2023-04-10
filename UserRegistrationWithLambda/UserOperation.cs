using System;
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
        public const string PASSWORD = "^[A-Z]{1,}[a-z]{5,}[!@#$%~]{1}[0-9]{0,}$";
        public static string[] mails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.xyz@bl.co.in", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc +100@gmail.com" };
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
        public void ValidatePasswordRule4(string passwd)
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
        public void ValidateEmails()
        {
            for (int i = 0; i < mails.Length; i++)
            {
                string data = mails[i];
                if (Regex.IsMatch(data, EMAIL))
                {
                    Console.WriteLine(data + " --> Valid mail id");
                }
                else
                {
                    Console.WriteLine(data + " --> Invalid mail id");
                }
            }
        }
    }
}
