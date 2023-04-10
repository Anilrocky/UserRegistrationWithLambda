using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class User
    {
        public const string NAME = "^[A-Z]{1}[a-z]{2,}$";
        public const string EMAIL = "^[a-zA-Z]{3,}[.]{0,1}[a-zA-Z]{0,}[@]{1}[a-zA-Z]{2,}[.]{1}[a-zA-Z]{2,}[.]{0,1}[a-zA-Z]{0,2}$";
        public const string MOBILE_NUMBER = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public const string PASSWORD = "^[A-Z]{1,}[a-z]{3,}[~!@#$&]{1,}[0-9]{1,}$";
        public string ValidateName(string name)
        {
            if (Regex.IsMatch(name, NAME))
                return "Valid";
            return "Invalid";
        }
        public string ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
                return "Valid";
            return "Invalid";
        }
        public string ValidateMobileNumber(string number)
        {
            if (Regex.IsMatch(number, MOBILE_NUMBER))
                return "Valid";
            return "Invalid";
        }
        public string ValidatePassword(string passwd)
        {
            if (Regex.IsMatch(passwd, PASSWORD))
                return "Valid";
            return "Invalid";
        }
        public string ValidateEmails(string[] email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                string mails = email[i];
                if (Regex.IsMatch(mails, EMAIL))
                    return "Valid";
                else
                    return "Invalid";
            }
            return "";
        }
    }
}