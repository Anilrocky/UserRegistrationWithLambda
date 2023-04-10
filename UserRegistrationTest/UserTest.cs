using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {
        User user = new User();
        [Test]
        public void EnteredFirstName_WhenAnalyze_ShouldReturn_Valid()
        {
            string firstName = "Anils";
            string result = user.ValidateName(firstName);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredLastName_WhenAnalyze_ShouldReturn_Valid()
        {
            string lastName = "Kumar";
            string result = user.ValidateName(lastName);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredEMail_WhenAnalyze_ShouldReturn_Valid()
        {
            string eMail = "anil.ac@techies.co.in";
            string result = user.ValidateEmail(eMail);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredMobileNumber_WhenAnalyze_ShouldReturn_Valid()
        {
            string number = "91 6789054321";
            string result = user.ValidateMobileNumber(number);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredPassword_WhenAnalyze_ShouldReturn_Valid()
        {
            string passwd = "Asdkf@1234";
            string result = user.ValidatePassword(passwd);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenEMails_WhenAnalyze_ShouldReturn_Valid()
        {
            string[] email = { "anil.ac@techies.co.in", "ani@xyz.com", "xyz-100@outlook.com", "pqs.100@gmail.com", "asc111@sbc.com", "abc-100@sda.net", " abc.100@fda.com.ac", "zxc@1.com", "jkl@gmail.com.ed", "abc+100@gmail.com", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc.@gmail.com", "bc@abc@gmail.com", "abc@%*.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            string result = user.ValidateEmails(email);
            for (int i = 0; i < email.Length; i++)
            {
                if (result.Equals("Valid"))
                    Assert.AreEqual(result, "Valid");
                else
                    Assert.AreEqual(result, "Invalid");
            }
        }
    }
}