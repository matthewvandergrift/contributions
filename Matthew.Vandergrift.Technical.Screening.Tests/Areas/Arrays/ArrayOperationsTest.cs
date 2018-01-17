using System;
using System.Collections.Generic;
using System.Linq;
using Matthew.Vandergrift.Technical.Screening.Areas.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Arrays
{
    [TestClass]
    public class ArrayOperationsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var arrayOperations = new ArrayOperations();
            var arrayInput = new int[][]
            {
                new int[] {1, 2, 3, 5, 4},
                new int[] {1, 3, 2, 5, 4},
                new int[] {1, 4, 3, 5, 2},
                new int[] {1, 5, 3, 2, 4},
                new int[] {2, 1, 3, 5, 4},
            };
            var expected = new HashSet<int> { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 };
            
            //Act
            var result = arrayOperations.MergeArrayForLoop(arrayInput);

            //Assert
            CollectionAssert.AreEqual(expected.ToList(), result.OrderBy(i => i).ToList());
        }
    }
}
