using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationWithLambda.UserRegistrationTest
{
    public class UserOperationTest
    {
        UserOperation user = new UserOperation();
        [Test]
        public void EnteredFirstName_WhenAnalyze_ShouldReturn_Valid()
        {
            string firstName = "Anil";
            string result = user.ValidateFirstName(firstName);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredLastName_WhenAnalyze_ShouldReturn_Valid()
        {
            string lastName = "Kumar";
            string result = user.ValidateLastName(lastName);
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
            string result = user.ValidatePhoneNumber(number);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredPassword_WhenAnalyze_ShouldReturn_Valid()
        {
            string passwd = "Asdkf@1234";
            string result = user.ValidatePasswordRule4(passwd);
            Assert.AreEqual(result, "Valid");
        }
    }
}
