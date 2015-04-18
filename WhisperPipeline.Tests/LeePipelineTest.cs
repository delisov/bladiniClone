using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperMessage;
using WhisperMessage.Pipeline;

namespace WhisperPipeline.Tests
{
    [TestClass]
    public class LeePipelineTest
    {

        private IWhisperPipeline _leePipeline = new LeePipeline();

        [TestMethod]
        public void PipelineTestLee()
        {

            //Arrange
            string value = "hej på dig fuck face!";
            string expected = "jfh + yo - äp * yo / hie + yo - lkokovf * yo = !fkokob";

            //Act
            string actual = _leePipeline.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
