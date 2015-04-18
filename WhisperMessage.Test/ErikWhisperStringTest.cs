using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperMessage.Test
{
    [TestClass]
    public class ErikWhisperStringTests
    {
        private IWhisperString _erikWhisperString = new ErikWhisperString();
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ErikManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            //Act
            string actual = _erikWhisperString.ManipulateMessage(value);
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ErikManipulateMessageNullThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _erikWhisperString.ManipulateMessage(value);
        }
        [TestMethod]
        public void ErikManipulateMessage()
        {
            //Arrange
            string value = "jag är glad";
            string expected = "stag bär glad";

            //Act
            string actual = _erikWhisperString.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
