using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC1RegExFirstName;
namespace FirstNameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void ValidateFirstName()
        {
            //Arrange
            ChkFirstName patternMatch = new ChkFirstName();

            string expected = "Invalid FirstName";

            //Act
            var result = patternMatch.Validate(null);


            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
