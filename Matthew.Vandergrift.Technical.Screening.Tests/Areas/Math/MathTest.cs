using System;
using Matthew.Vandergrift.Technical.Screening.Areas.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Math
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Add2IntegersAndReturnIndicesOfPartsByTarget()
        {
            //Arrange
            var mathProblems = new MathProblemsOutsideTheBox();

            //Act 
            var result = mathProblems.Add2IntegersAndReturnIndicesByTarget(9);

            //Assert
            CollectionAssert.AreEqual(result, new[] {0,1});
        }
    }
}
