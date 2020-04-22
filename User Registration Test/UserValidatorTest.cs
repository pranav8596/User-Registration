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
    }
}