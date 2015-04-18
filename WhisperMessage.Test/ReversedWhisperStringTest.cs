using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperMessage.Test
{
    [TestClass]
    public class ReversedWhisperStringTest
    {
        IWhisperString _reverseMessage = new ReverseWhisperMessage();
        [TestMethod]
        public void ReverseWhisperMessageTest()
        {
            //Arrange
            string value = "Hej på dig";
            string expected = "Jeh åp gid";

            //Act
            string actual = _reverseMessage.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ReversedMessageArgumentException()
        {
            string value = "";
            string actual = _reverseMessage.ManipulateMessage(value);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ReversedMessageArgumentNullException()
        {
            string value = null;
            string actual = _reverseMessage.ManipulateMessage(value);
        }
    }
}
