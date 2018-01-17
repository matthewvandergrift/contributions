using System;
using Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Doubly;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.LinkedList.Doubly
{
    [TestClass]
    public class DoublyLinkedListTest
    {
        private static DoublyLinkedList<int> GetGenericLinkedList()
        {
            // Test with a non-empty list of integers.
            var gll = new DoublyLinkedList<int>();

            //fill the LinkedList
            gll.AddNodeFromFront(30);
            gll.AddNodeFromFront(20);
            gll.AddNodeFromFront(10);

            return gll;
        }

        [TestMethod]
        public void GetFirstAddedFromFrontPreviousData()
        {
            //Arrange
            var expected = 10;
            var gll = GetGenericLinkedList();

            //Act 
            var actual = gll.GetFirstAddedFromFrontNode().Prev;

            //Assert
            // The following line should equal 10.
            Assert.AreEqual<int>(expected, (int)actual.Data);
        }
    }
}
