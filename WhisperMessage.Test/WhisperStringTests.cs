using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperMessage.Test
{
    [TestClass]
    public class WhisperStringTests
    {
        private IWhisperString _whisperString = new WhisperString();

        [TestMethod]
        public void ManipulateMessageWithVowels()
        {
            //Arrange
            string value = "Hej! Detta är ett meddelande.";
            string expected = "Hij! Ditti ir itt middilindi.";

            //Act
            string actual = _whisperString.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ManipulateMessageWithoutVowels()
        {
            //Arrange
            string value = "ghfklj";
            string expected = "ghfklj";

            //Act
            string actual = _whisperString.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            //Act
            string actual = _whisperString.ManipulateMessage(value);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ManipulateMessageNullInputThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _whisperString.ManipulateMessage(value);
        }

    }
}
