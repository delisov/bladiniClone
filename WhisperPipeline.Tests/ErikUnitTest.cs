using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperMessage.Pipeline
{
    [TestClass]
    public class ErikUnitTest
    {
        private IWhisperPipeline _erikPipeline = new ErikPipeline();

        [TestMethod]
        public void ErikPipelineTest()
        {
            //Arrange
            string value = "Hej och hå";
            string expected = "Jeh  oy  hokoko  oy  åh";


            //Act
            string actual = _erikPipeline.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

