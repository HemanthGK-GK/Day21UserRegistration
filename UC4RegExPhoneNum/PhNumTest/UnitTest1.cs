using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC4RegExPhoneNum;
namespace PhNumTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC4
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void ValidateMobileNumber()
        {
            //Arrange
            Phone patternMatch = new Phone();
            bool expected = true;

            //Act
            //var result = patternMatch.ValidatePhoneNumber(null);
            var result = patternMatch.Validate("91 7504832115");

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
