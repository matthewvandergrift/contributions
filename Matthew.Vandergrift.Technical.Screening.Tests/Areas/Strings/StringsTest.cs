using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Strings
{
    [TestClass]
    public class StringsTest
    { 
        [TestMethod]
        public void CompareStringsPrecedesString()
        {
            //Arrange
            string a = "String";
            string b = "STRING";
            int c;

            //Act
            c = a.CompareTo(b);

            //Assert
            Assert.IsTrue( c== -1);
        }

        [TestMethod]
        public void CompareStringsEquals()
        {
            //Arrange
            string a = "STRING";
            string b = "STRING";
            int c;

            //Act
            c = a.CompareTo(b);

            //Assert
            Assert.IsTrue(c == 0);
        }

        [TestMethod]
        public void CompareStringsFollows()
        {
            //Arrange
            string a = "STRING";
            string b = "string";
            int c;

            //Act
            c = a.CompareTo(b);

            //Assert
            Assert.IsTrue(c > 0);
        }
    }
}
