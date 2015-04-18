using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperMessage;
using WhisperMessage.Pipeline;

namespace WhisperPipeline
{
    public class YoWhisperPipeline : IWhisperPipeline
    {
        private IWhisperString _reverseWhisperMessage = new ReverseWhisperMessage();
        private IWhisperString _whisperSecondNext = new WhisperSecondNext();
        public string Whisper(string message)
        {
            message = _reverseWhisperMessage.ManipulateMessage(message);

            message = _whisperSecondNext.ManipulateMessage(message);
            
            return message;
        }
    }
}
