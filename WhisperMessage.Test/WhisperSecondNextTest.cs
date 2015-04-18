using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperMessage.Test
{
    /// <summary>
    /// Summary description for WhisperSecondNextTest
    /// </summary>
    [TestClass]
    public class WhisperSecondNextTest
    {
        private IWhisperString _whisperString = new WhisperSecondNext();


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SNManipulateMessageshiftsWithNoNumbers()
        {
            string value = "aaaz";
            string expected = "abaå";
            string actual = _whisperString.ManipulateMessage(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SNManipulateMessageshiftsWithNumbers()
        {
            string value = "aaazv3a";
            string expected = "abaåv3d";
            string actual = _whisperString.ManipulateMessage(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void SNManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            //Act
            string actual = _whisperString.ManipulateMessage(value);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void SNManipulateMessageNullInputThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _whisperString.ManipulateMessage(value);
        }
    }
}
