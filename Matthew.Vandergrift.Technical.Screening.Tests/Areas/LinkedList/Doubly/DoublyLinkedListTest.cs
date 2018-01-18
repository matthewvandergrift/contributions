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

        [TestMethod]
        public void RemoveAnItemFromTheLinkedList()
        {
            //Arrange
            var expected = new DoublyLinkedList<int>();

            //fill the LinkedList
            expected.AddNodeFromFront(30);
            //miss 20 because we are gonna remove that one
            //expected.AddNodeFromFront(20);
            expected.AddNodeFromFront(10);

            var gll = GetGenericLinkedList();

            //Act 
            var actual = gll.DeleteNodeAtPositionStartingFromFront(2);

            //Assert
            // The following line should equal 10.
            Assert.IsTrue((int)expected.GetHead().Next.Data == (int)actual.GetHead().Next.Data);
        }
    }
}
