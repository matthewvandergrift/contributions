using Matthew.Vandergrift.Technical.Screening.Areas.LinkedList.Singly;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.LinkedList.Singly
{
    [TestClass]
    public class SinglyLinkedListTest
    {
        private static SinglyLinkedList<int> GetGenericLinkedList()
        {
            // Test with a non-empty list of integers.
            var gll = new SinglyLinkedList<int>();

            //fill the LinkedList
            gll.AddNodeFromFront(30);
            gll.AddNodeFromFront(20);
            gll.AddNodeFromFront(10);

            return gll;
        }

        [TestMethod]
        public void GetFirstAdded()
        {
            //Arrange
            var expected = 20;
            var gll = GetGenericLinkedList();

            //Act 
            var actual = gll.GetFirstAddedFromFrontData();

            //Assert
            // The following line should equal 20.
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void GetSecondAddedUsingExpression()
        {
            //Arrange
            var expected = 30;
            var ordinal = 1;
            var gll = GetGenericLinkedList();

            //Act 
            var actual = gll.GetNodeAtPositionAddedFromFront(ordinal);

            //Assert
            // The following line should equal 30.
            Assert.AreEqual<int>(expected, (int)actual.Data);
        }

        [TestMethod]
        public void GetSecondAddedReversedListUsingExpression()
        {
            //Arrange
            var expected = 10;
            var ordinal = 1;
            var gll = GetGenericLinkedList();

            //Act 
            //Reverse the list
            gll.Reverse();
            //Now fetch the node
            var actual = gll.GetNodeAtPositionAddedFromFront(ordinal);

            //Assert
            // The following line should equal 10.
            Assert.AreEqual<int>(expected, (int)actual.Data);
        }

        [TestMethod]
        public void AddNodeFromLast()
        {
            //Arrange
            var expected = 40;
            var gll = GetGenericLinkedList();

            //Act 
            gll.AddNodeFromLast(40);
            var actual = gll.GetLastAddedFromFrontNode();

            //Assert
            // The following line should equal 40.
            Assert.AreEqual<int>(expected, (int)actual.Data);
        }

        [TestMethod]
        public void GetMinimumValueFromList()
        {
            //Arrange
            var expected = 10;
            var gll = GetGenericLinkedList();

            //Act 
            var actual = gll.GetMinimumValueNodeFromFront();

            //Assert
            // The following line should equal 10.
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
