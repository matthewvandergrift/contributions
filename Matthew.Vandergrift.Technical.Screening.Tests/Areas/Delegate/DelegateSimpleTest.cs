using System;
using Matthew.Vandergrift.Technical.Screening.Areas.Deletegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matthew.Vandergrift.Technical.Screening.Tests.Areas.Delegate
{
    [TestClass]
    public class DelegateSimpleTest
    {
        [TestMethod]
        public void SimpleDelegateMethod()
        {
            //Arrange
            var delegateSimple = new DelegateSimple();

            //Act
            var result = delegateSimple.Process();

            //Assert
            Assert.IsTrue(result);
        }

        private string _loggingActual;

        [TestMethod]
        public void EventDelegateMethod()
        {
            //Arrange
            var _loggingExpected = "beginend";
            var fl = new FileLogger("process.log");

            var delegateSimple = new DelegateSimple();

            // Subscribe the Functions Logger and fl.Logger
            delegateSimple.Log += Logger;
            delegateSimple.Log += fl.Logger;

            //Act
            // The Event will now be triggered in the Process() Method
            delegateSimple.Process();

            //close the stream
            fl.Close();

            //Assert
            Assert.IsTrue(_loggingExpected == _loggingActual);
        }

        private void Logger(string s)
        {
            _loggingActual += s;
        }
    }
}
