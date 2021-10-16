using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC2RegExLastName;
namespace LastNameTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC2
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void ValidateLastName()
        {
            //Arrange
            ChkLastName patternMatch = new ChkLastName();
            string expected = "Invalid LastName";

            //Act
            var result = patternMatch.Validate(null);


            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
