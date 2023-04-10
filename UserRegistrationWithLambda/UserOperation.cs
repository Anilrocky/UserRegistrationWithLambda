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
        public bool ValidateFirstNameByLambda() => Regex.IsMatch(Console.ReadLine(), "^[A-Z]{1}[a-z]{2,}$") ? true : false;
        public bool ValidateLastNameByLambda() => Regex.IsMatch(Console.ReadLine(), "^[A-Z]{1}[a-z]{2,}$") ? true : false;
        public bool ValidateEmailByLambda() => Regex.IsMatch(Console.ReadLine(), "^[a-zA-Z]{3,}[.]{0,1}[a-zA-Z]{0,}[@]{1}[a-zA-Z]{2,}[.]{1}[a-zA-Z]{2,3}[.]{0,1}[a-zA-Z]{0,2}$") ? true : false;
        public bool ValidateMobileNumberByLambda() => Regex.IsMatch(Console.ReadLine(), "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$") ? true : false;
        public bool ValidatePasswordByLambda() => Regex.IsMatch(Console.ReadLine(), "^[A-Z]{1,}[a-z]{3,}[!@#$%~]{1}[0-9]{0,}$") ? true : false;
    }
}
