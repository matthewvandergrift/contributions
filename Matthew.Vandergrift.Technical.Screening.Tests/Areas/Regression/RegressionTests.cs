using Matthew.Vandergrift.Technical.Screening.Areas.Regression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Regression
{
    [TestClass]
    public class RegressionTests
    {
        [TestMethod]
        public void FibonacciTo5Places()
        {
            //Arrange
            var regression = new RegressionQuick();

            //Act
            var result = regression.CalculateFibonacci(5);

            //Assert
            Assert.IsTrue(result == 5);
        }
    }
}
