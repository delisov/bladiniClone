using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperMessage.Test
{
    [TestClass]
    public class WhisperCensorTest
    {
        private IWhisperString _whisperCensor = new WhisperCensor();

        [TestMethod]
        public void ManipulateMessageWithCensor()
        {
            //Arrange
            string value = "fuck, hello";
            string expected = "****, hello";

            //Act
            string actual = _whisperCensor.ManipulateMessage(value);


            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ManipulateMessageWithEmptystringCensor()
        {
            string value = "";

            string actual = _whisperCensor.ManipulateMessage(value);



        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ManipulateMessageWithNullCensor()
        {
            string value = null;

            string actual = _whisperCensor.ManipulateMessage(value);
        }
    }
}
