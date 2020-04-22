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
        public void givenFirstName_WhenProper_ShouldReturnTrue()
        {
            bool result = userValidator.validateName("Pranav");
            Assert.IsTrue(result);
        }

        [Test]
        public void givenFirstName_WhenImProper_ShouldReturnFalse()
        {
            bool result = userValidator.validateName("pranav");
            Assert.IsFalse(result);
        }

    }
}