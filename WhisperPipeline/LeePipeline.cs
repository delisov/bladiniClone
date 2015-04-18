using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperMessage;
using WhisperMessage.Pipeline;

namespace WhisperPipeline
{
    public class LeePipeline : IWhisperPipeline
    {

        private IWhisperString _whisperCalc = new WhisperCreateCalculation();
        private IWhisperString _whisperReverse = new ReverseWhisperMessage();
        private IWhisperString _whisperSecondNext = new WhisperSecondNext();
        private IWhisperString _whisperKoko = new WhisperStringKoko();
        private IWhisperString _whisperYo = new YoWhisperString();

        public string Whisper(string message)
        {

            message = _whisperReverse.ManipulateMessage(message);
            message = _whisperSecondNext.ManipulateMessage(message);
            message = _whisperKoko.ManipulateMessage(message);
            message = _whisperYo.ManipulateMessage(message);
            message = _whisperCalc.ManipulateMessage(message);

            return message;

        }
    }
}
