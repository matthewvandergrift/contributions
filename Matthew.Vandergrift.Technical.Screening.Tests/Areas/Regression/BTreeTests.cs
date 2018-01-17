using System;
using Matthew.Vandergrift.Technical.Screening.Areas.Regression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Regression
{
    [TestClass]
    public class BTreeTests
    {
        private static BTree CreateTree()
        {
            var bTree = new BTree();
            bTree.Insert(20);
            bTree.Insert(15);
            bTree.Insert(13);
            bTree.Insert(16);
            bTree.Insert(25);
            bTree.Insert(22);
            bTree.Insert(45);

            return bTree;
        }
        [TestMethod]
        public void BTreeTraversalPreOrder()
        {
            //Arrange
            var tree = CreateTree();
            var expected = "20 15 13 16 25 22 45 ";

            //Act
            tree.PreOrder(tree.ReturnRoot());
            var result = tree.output.ToString();

            //Assert
            Assert.IsTrue(result == expected);
        }
    }
}
