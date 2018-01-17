using System;
using Matthew.Vandergrift.Technical.Screening.Areas.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.LinkedList
{
    [TestClass]
    public class LinkedListTest
    {
        private static GenericLinkedList<int> GetGenericLinkedList()
        {
            // Test with a non-empty list of integers.
            var gll = new GenericLinkedList<int>();

            //fill the LinkedList
            gll.AddNode(30);
            gll.AddNode(20);
            gll.AddNode(10);

            return gll;
        }

        [TestMethod]
        public void GetFirstAdded()
        {
            //Arrange
            var expected = 20;
            var gll = GetGenericLinkedList();

            //Act 
            var actual = gll.GetFirstAddedData();

            //Assert
            // The following line should equal 20.
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void GetSecondAddedUsingExpression()
        {
            //Arrange
            var expected = 30;
            var ordinal = 2;
            var gll = GetGenericLinkedList();

            //Act 
            var actual = gll.GetNodeAt(ordinal);

            //Assert
            // The following line should equal 30.
            Assert.AreEqual<int>(expected, (int)actual.Data);
        }
    }
}
