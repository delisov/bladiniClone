using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperMessage.Test
{
    [TestClass]
    public class YoWhisperStringTests
    {
        private IWhisperString _yoWhisperString = new YoWhisperString();
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void YoManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            //Act
            string actual = _yoWhisperString.ManipulateMessage(value);
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void YoManipulateMessageNullThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _yoWhisperString.ManipulateMessage(value);
        }
        [TestMethod]
        public void YoManipulateMessageEveryWhiteSpaceWithYou()
        {
            //Arrange
            string value = "Hur mår du da ";
            string expected = "Hur yo mår yo du yo da yo ";

            //Act
            string actual = _yoWhisperString.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
