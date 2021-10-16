using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC5Password;
namespace PasswordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void ValidatePassword()
        {
            //Arrange
            Password patternMatch = new Password();
            bool expected = true;

            //Act
            //var result = patternMatch.ValidatePassword(null);
            var result = patternMatch.Validate("Tr5h7$stU");

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
