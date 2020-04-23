using NUnit.Framework;
using User_Registration_Main;

namespace User_Registration_Test
{
    public class UserValidatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        UserValidator userValidator = new UserValidator();

        [Test]
        //Test should return True if First Name is Proper
        public void givenFirstName_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validateName("Pranav");
            Assert.IsTrue(result);
        }

        [Test]
        //Test should return False if First Name is Improper
        public void givenFirstName_WhenImProper_ShouldReturnFalse()
        {
            bool result = userValidator.validateName("pranav");
            Assert.IsFalse(result);
        }

        [Test]
        //Test should return True if Last Name is Proper
        public void givenLastName_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validateName("Ige");
            Assert.IsTrue(result);
        }

        [Test]
        //Test should return False if Last Name is Improper
        public void givenLastName_WhenImProper_ShouldReturnFalse()
        {
            bool result = userValidator.validateName("ige");
            Assert.IsFalse(result);
        }

        [Test]
        //Test should return True if EMail is proper
        public void givenEmailAddress_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validateEmail("pranav.ige96@gmail.com");
            Assert.IsTrue(result);
        }

        [Test]
        //Test should return False if "@" is missing
        public void givenEmailAddress_WhenNoAtSymbol_ShouldReturnFalse()
        {
            bool result = userValidator.validateEmail("pranav.ige96gmail.com");
            Assert.IsFalse(result);
        }

        [Test]
        //Test should return False if domain is missing
        public void givenEmailAddress_WhenNoDomain_ShouldReturnFalse()
        {
            bool result = userValidator.validateEmail("pranav.ige96@.com");
            Assert.IsFalse(result);
        }

        [Test]
        //Test should return False if TLD is missing
        public void givenEmailAddress_WhenNoTLD_ShouldReturnFalse()
        {
            bool result = userValidator.validateEmail("pranav.ige96@gmail");
            Assert.IsFalse(result);
        }

        [Test]
        //Test should return True if Mobile Number is proper
        public void givenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validateMobileNumber("91 9167249096");
            Assert.IsTrue(result);
        }

        [Test]
        //Test should return False if there is No Space
        public void givenMobileNumber_WheNoSpace_ShouldReturnFalse()
        {
            bool result = userValidator.validateMobileNumber("919167249096");
            Assert.IsFalse(result);
        }

        [Test]
        //Test should return False if digits are Not 10
        public void givenMobileNumber_WhenDigitsNotTen_ShouldReturnFalse()
        {
            bool result = userValidator.validateMobileNumber("91 916724");
            Assert.IsFalse(result);
        }

        [Test]
        // Rule 1: Minimum 8 characters
        // Test should return True if Password Rule 1 is proper
        public void givenPasswordRule1_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validatePassword("pranavige", userValidator.PASSWORD_PATTERN1);
            Assert.IsTrue(result);
        }

        [Test]
        //Test should return False if Password contains One or more upper case
        public void givenPasswordRule1_WhenUpperCase_ShouldReturnFalse()
        {
            bool result = userValidator.validatePassword("PranavIge", userValidator.PASSWORD_PATTERN1);
            Assert.IsFalse(result);
        }

        [Test]
        // Rule 2: Atleast one upper case
        // Test should return True if Password Rule 2 is proper
        public void givenPasswordRule2_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validatePassword("PranavIge", userValidator.PASSWORD_PATTERN2);
            Assert.IsTrue(result);
        }


    }
}