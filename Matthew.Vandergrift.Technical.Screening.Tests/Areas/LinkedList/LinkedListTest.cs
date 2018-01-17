using System;
using Matthew.Vandergrift.Technical.Screening.Areas.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.LinkedList
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void GetFirstAdded()
        {
            //Arrange
            // Test with a non-empty list of integers.
            var gll = new GenericLinkedList<int>();

            var expected = 5;

            //Act 
            //fill the LinkedList
            gll.AddNode(expected);
            gll.AddNode(4);
            gll.AddNode(3);

            var actual = gll.GetFirstAdded();

            //Assert
            // The following line should equal 5.
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
