using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhisperMessage.Pipeline
{
    public class ErikPipeline : IWhisperPipeline
    {
        private IWhisperString yo = new YoWhisperString();
        private IWhisperString koko = new WhisperStringKoko();
        private IWhisperString erik = new ErikWhisperString();
        private IWhisperString lee = new WhisperCreateCalculation();
        private IWhisperString reverse = new ReverseWhisperMessage();



        public string Whisper(string message)
        {
            string str = yo.ManipulateMessage(message);
            str = koko.ManipulateMessage(str);
            str = erik.ManipulateMessage(str);
            str = lee.ManipulateMessage(str);
            str = reverse.ManipulateMessage(str);

            return str;
        }
    }
}
