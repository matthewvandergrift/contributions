using System;
using System.Collections.Generic;
using Matthew.Vandergrift.Technical.Screening.Areas.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Math
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Add2IntegersAndReturnIndicesOfPartsByTargetKnown()
        {
            //Arrange
            var mathProblems = new MathProblemsOutsideTheBox();

            //Act 
            var result = mathProblems.Add2IntegersAndReturnIndicesByTargetKnown(9);

            //Assert
            CollectionAssert.AreEqual(result, new[] {0,1});
        }

        [TestMethod]
        public void Add2IntegersAndReturnIndicesOfPartsByTargetUnknownForI()
        {
            //Arrange
            var mathProblems = new MathProblemsOutsideTheBox();
            var list = new List<int>() {2, 7, 11, 15};

            //Act 
            var result = mathProblems.Add2IntegersAndReturnIndicesByTargetUnknownForI(list, 9);

            //Assert
            Assert.AreEqual(result, new Tuple<int,int>( 0, 1 ));
        }

        [TestMethod]
        public void Add2IntegersAndReturnIndicesOfPartsByTargetUnknownForLoop()
        {
            //Arrange
            var mathProblems = new MathProblemsOutsideTheBox();
            var list = new List<int>() { 2, 7, 11, 15 };

            //Act 
            var result = mathProblems.Add2IntegersAndReturnIndicesByTargetUnknownForLoop(list, 9);

            //Assert
            Assert.AreEqual(result, new Tuple<int, int>(0, 1));
        }

        [TestMethod]
        public void Divide2IntegersWithoutUsingDivideOrModulusOperator()
        {
            //Arrange
            var dividend = 13;
            var divisor = 4;
            var expected = "13 goes into 4: 3 time(s) with 1 remaining.";
            var mathProblems = new MathProblemsOutsideTheBox();

            //Act
            var result = mathProblems.Divide2IntegersWithoutDivideOrModulusOperators(dividend, divisor);

            //Assert
           Assert.AreEqual(expected,result);
        }
    }
}
