using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhisperMessage
{
    public class ErikWhisperString : IWhisperString
    {
        public string ManipulateMessage(string message)
        {
            if (message == null)
                throw new ArgumentNullException("Message is null.");
            if (message.Trim().Equals(""))
                throw new ArgumentException("Message is empty.");

            message = message.Replace("är", "bär");
            message = message.Replace("har", "tar");
            message = message.Replace("går", "lår");
            message = message.Replace("jag", "stag");

            return message;
        }
    }
}
