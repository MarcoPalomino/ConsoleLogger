using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleLogger.Tests
{
    [TestClass]
    public class ConsoleLoggerTests
    {
        [TestMethod]
        public void VerifyConsoleLogWasSuccessfullySaved()
        {

            //Arrange
            var logger = new Logger();
            var logType = "LogType";
            var logMessage = "LogMessage";

            //Act
            var wasSuccessfullyLogged = logger.DoLog(logType, logMessage);

            //Assert
            Assert.IsTrue(wasSuccessfullyLogged);
        }
    }
    
}
