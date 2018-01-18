using System;
using System.Collections.Generic;
using System.Linq;
using Matthew.Vandergrift.Technical.Screening.Areas.Regression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Regression
{
    [TestClass]
    public class NumbersProblemTest
    {
        [TestMethod]
        public void FindMissingIntegerInIntegerList()
        {
            //Arrange
            var expected = new List<int> {17};
            var integers = new List<int>
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18, 19, 20, 21, 22, 23, 24, 25};
           var numberProblem = new NumbersProblem();

            //Act 
            var actual = numberProblem.FindTheMissingInteger(integers).ToList();

            //Assert
            // The following value should be 17
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
