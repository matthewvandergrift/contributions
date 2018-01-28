using System.Collections.Generic;
using Matthew.Vandergrift.Technical.Screening.Areas.Regression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Regression
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        [TestCategory("Positive")]
        public void BubbleSortRun()
        {
            //arrange
            var array = new List<int> {32, 12, 25, 22, 21, 21, 20, 55};
            var bubbleSort = new BubbleSort(array);

            //act
            var result = bubbleSort.SortArray();

            //assert
            CollectionAssert.AreEquivalent(result , new List<int> { 12, 20, 21,21, 22, 25,32,55});
        }
    }
}
