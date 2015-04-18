using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperMessage;
using WhisperMessage.Pipeline;

namespace WhisperPipeline
{
    public class SingPipeline : IWhisperPipeline
    {

        private IWhisperString _whisperKoko = new WhisperStringKoko();
        private IWhisperString _yoWhisper = new YoWhisperString();
        private IWhisperString _whisperReverse = new ReverseWhisperMessage();
        

        public string Whisper(string message)
        {
            message = _whisperKoko.ManipulateMessage(message);
            message = _yoWhisper.ManipulateMessage(message);
            message = _whisperReverse.ManipulateMessage(message);



            return message;
        }
    }
}
