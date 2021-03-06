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
            Assert.AreEqual(true, result);
        }

        [Test]
        //Test should return False if First Name is Improper
        public void givenFirstName_WhenImProper_ShouldReturnFalse()
        {
            bool result = userValidator.validateName("pranav");
            Assert.AreEqual(false, result);
        }

        [Test]
        //Test should return True if Last Name is Proper
        public void givenLastName_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validateName("Ige");
            Assert.AreEqual(true, result);
        }

        [Test]
        //Test should return False if Last Name is Improper
        public void givenLastName_WhenImProper_ShouldReturnFalse()
        {
            bool result = userValidator.validateName("ige");
            Assert.AreEqual(false, result);
        }

        [Test]
        //Test should return True if EMail is proper
        public void givenEmailAddress_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validateEmail("pranav.ige96@gmail.com");
            Assert.AreEqual(true, result);
        }

        [Test]
        //Test should return False if "@" is missing
        public void givenEmailAddress_WhenNoAtSymbol_ShouldReturnFalse()
        {
            bool result = userValidator.validateEmail("pranav.ige96gmail.com");
            Assert.AreEqual(false, result);
        }

        [Test]
        //Test should return False if domain is missing
        public void givenEmailAddress_WhenNoDomain_ShouldReturnFalse()
        {
            bool result = userValidator.validateEmail("pranav.ige96@.com");
            Assert.AreEqual(false, result);
        }

        [Test]
        //Test should return False if TLD is missing
        public void givenEmailAddress_WhenNoTLD_ShouldReturnFalse()
        {
            bool result = userValidator.validateEmail("pranav.ige96@gmail");
            Assert.AreEqual(false, result);
        }

        [Test]
        //Test should return True if Mobile Number is proper
        public void givenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validateMobileNumber("91 9167249096");
            Assert.AreEqual(true, result);
        }

        [Test]
        //Test should return False if there is No Space
        public void givenMobileNumber_WheNoSpace_ShouldReturnFalse()
        {
            bool result = userValidator.validateMobileNumber("919167249096");
            Assert.AreEqual(false, result);
        }

        [Test]
        //Test should return False if digits are Not 10
        public void givenMobileNumber_WhenDigitsNotTen_ShouldReturnFalse()
        {
            bool result = userValidator.validateMobileNumber("91 916724");
            Assert.AreEqual(false, result);
        }

        [Test]
        // RULE 1: Minimum 8 characters
        // Test should return True if Password Rule 1 is proper
        public void givenPasswordRule1_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validatePassword("pranavige", userValidator.PASSWORD_PATTERN1);
            Assert.AreEqual(true, result);
        }

        [Test]
        //Test should return False if Password contains less than 8 characters
        public void givenPasswordRule1_WhenUpperCase_ShouldReturnFalse()
        {
            bool result = userValidator.validatePassword("pra", userValidator.PASSWORD_PATTERN1);
            Assert.AreEqual(false, result);
        }

        [Test]
        // RULE 2: Atleast one upper case
        // Test should return True if Password Rule 2 is proper
        public void givenPasswordRule2_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validatePassword("PranavIge", userValidator.PASSWORD_PATTERN2);
            Assert.AreEqual(true, result);
        }

        [Test]
        // Test should return False if Password has all lower case chars
        public void givenPasswordRule2_WhenAllLowerCase_ShouldReturnFalse()
        {
            bool result = userValidator.validatePassword("pranavige", userValidator.PASSWORD_PATTERN2);
            Assert.AreEqual(false, result);
        }

        [Test]
        // RULE 3: Atleast one Numeric number
        // Test should return True if Password Rule 3 is proper
        public void givenPasswordRule3_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validatePassword("Pranav9Ige6", userValidator.PASSWORD_PATTERN3);
            Assert.AreEqual(true, result);
        }

        [Test]
        // Test should return False if Password has no numeric number
        public void givenPasswordRule3_WhenNoNumeric_ShouldReturnFalse()
        {
            bool result = userValidator.validatePassword("IamPranavIge", userValidator.PASSWORD_PATTERN3);
            Assert.AreEqual(false, result);
        }

        [Test]
        // RULE 4: Exacly 1 special character
        // Test should return True if Password Rule 4 is proper
        public void givenPasswordRule4_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validatePassword("Pranav996#Ige6", userValidator.PASSWORD_PATTERN4);
            Assert.AreEqual(true, result);
        }

        [Test]
        // Test should return False if it has more than 1 special characters
        public void givenPasswordRule4_WhenMoreThan1SpecialChars_ShouldReturnFalse()
        {
            bool result = userValidator.validatePassword("Pranav@996#Ige6!", userValidator.PASSWORD_PATTERN4);
            Assert.AreEqual(false, result);
        }

        [Test]
        // Test should return False if there is No special characters
        public void givenPasswordRule4_WhenNoSpecialChars_ShouldReturnFalse()
        {
            bool result = userValidator.validatePassword("Pranav96Ige6", userValidator.PASSWORD_PATTERN4);
            Assert.AreEqual(false, result);
        }
    }
}