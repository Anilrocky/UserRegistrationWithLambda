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
    }
}
