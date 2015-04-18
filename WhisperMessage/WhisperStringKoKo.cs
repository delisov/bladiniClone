using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhisperMessage
{
    public class WhisperStringKoko : IWhisperString
    {
        public string ManipulateMessage(string message)
        {
            if (message == null)
                throw new ArgumentNullException("Message is null.");
            if (message.Trim().Equals(""))
                throw new ArgumentException("Message is empty.");

            return Regex.Replace(message, "[c,k]", "koko");


        }
    }
}
