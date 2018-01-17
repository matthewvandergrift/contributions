using System.Linq;
using Matthew.Vandergrift.Technical.Screening.Areas.Lambda;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Lambda
{
    [TestClass]
    public class LambdaExpressionsTest
    {
        [TestMethod]
        [TestCategory("Negative")]
        public void CallAnonymousMethodLambdaAsync()
        {
            //Arrange
            var expected = 5;
            var actual = 4;

            //Act
            var result = new LambdaExpressions().ExampleAnonymousMethodAsync(expected, actual).Result;
            
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void CallMethodLambdaSync()
        {
            //Arrange
            var expected = 5;
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Act
            int oddNumbers = numbers.Count(n => n % 2 == 1);

            //Assert
            Assert.IsTrue(oddNumbers == expected);
        }
    }
}
