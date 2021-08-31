using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        public User user;

        [TestInitialize]
        public void SetUp()
        {
            user = new User();
        }
        /// <summary>
        /// Happy TestCases
        /// </summary>
        [TestMethod]
        public void FirstNameValidationShouldReturnTrue()
        {
            //Arrange
            string firstName = "Anil";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameValidationShouldReturnTrue()
        {
            //Arrange
            string lastName = "Kumar";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailValidationShouldReturnTrue()
        {
            //Arrange
            string email = "Anil07@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnTrue()
        {
            //Arrange
            string mobileNumber = "91 9494400887";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationShouldReturnTrue()
        {
            //Arrange
            string password = "Anil@07";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Sad Test Cases
        /// </summary>
        [TestMethod]
        public void FirstNameValidationShouldReturnFalse()
        {
            //Arrange
            string firstName = "Anil";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameValidationShouldReturnFalse()
        {
            //Arrange
            string lastName = "kumar";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailValidationShouldReturnFalse()
        {
            //Arrange
            string email = "anil@com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnFalse()
        {
            //Arrange
            string mobileNumber = "91 9494400886";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationShouldReturnFalse()
        {
            //Arrange
            string password = "Anil07";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateSampleEmailsShouldReturnTrue(string email)
        {
            Assert.IsTrue(user.ValidateEmail(email));
        }
        [TestMethod]
        public void FirstNameValidationShouldReturnException()
        {
            try
            {
                //Arrange
                string firstName = "Anil";
                //Act
                bool result = user.ValidateFirstName(firstName);
            }
            catch (InvalidUserException ex)
            {
                //Assert
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void LastNameValidationShouldReturnException()
        {
            try
            {
                //Arrange
                string lastName = "Kumar";
                //Act
                bool result = user.ValidateLastName(lastName);
            }
            catch (InvalidUserException ex)
            {
                //Assert
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void EmailValidationShouldReturnException()
        {
            try
            {
                //Arrange
                string email = "Anil43@gmail.com";
                //Act
                bool result = user.ValidateEmail(email);
            }
            catch (InvalidUserException ex)
            {
                //Assert
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnException()
        {
            try
            {
                string mobileNumber = "91 9494400886";
                bool result = user.ValidateMobileNumber(mobileNumber);
            }
            catch (InvalidUserException ex)
            {
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void PasswordValidationShouldReturnException()
        {
            try
            {
                //Arrange
                string password = "Anil@07";
                //Act
                bool result = user.ValidatePassword(password);
            }
            catch (InvalidUserException ex)
            {
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
    }
}