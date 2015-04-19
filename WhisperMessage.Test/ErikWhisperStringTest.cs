using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperMessage.Test
{
    [TestClass]
    public class ErikWhisperStringTests
    {
        private IWhisperString _erikWhisperString = new ErikWhisperString();
        [TestMethod]
        public void ErikManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            //Act
            try
            {
                string actual = _erikWhisperString.ManipulateMessage(value);
                Assert.Fail("No exception on empty string!");
            }
            catch (ArgumentException)
            {
                //OK
            }
        }
        [TestMethod]
        public void ErikManipulateMessageNullThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            try
            {
                string actual = _erikWhisperString.ManipulateMessage(value);
                Assert.Fail("No exception on empty string!");
            }
            catch (ArgumentException ex)
            {
                //OK
            }
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
