using System;
using Matthew.Vandergrift.Technical.Screening.Areas.Pointers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Pointers
{
    [TestClass]
    public class PointerTest
    {
        [TestMethod]
        public void CheckAgeUsingPointer()
        {
            //Arrange
            const int pAge = 32;
            const int increase = 3;
            var p = new Pointer
            {
                Age = pAge
            };

            //Act
            p.IncrementAge(increase);

            //Assert
            Assert.IsTrue(p.DisplayAge().Contains((pAge + increase).ToString()));
        }
    }
}
