using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WhisperMessage;

namespace WhisperMessage.Test
{
    [TestClass]
    public class WhisperStringKokoTest
    {

        private IWhisperString _whisperStringKoko = new WhisperStringKoko();

        [TestMethod]
        public void ManipulateMessageWithVowels()
        {
            //Arrange
            string value = "this is ur cake messagee";
            string expected = "this is ur kokoakokoe messagee";

            //Act
            string actual = _whisperStringKoko.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
