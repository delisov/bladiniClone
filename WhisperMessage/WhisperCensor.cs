using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WhisperMessage;

namespace WhisperMessage
{
    public class WhisperCensor : IWhisperString
    {
        public string ManipulateMessage(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("Message is null");
            }

            if (message.Trim().Equals(""))
            {
                throw new ArgumentException("Message is empty");
            }


            string[] badWords = { "fuck", "shit", "shitter", "fag", "faggot", "dick", "dickhead", "dumbshit", "ass", "asshole" };

            foreach (string badword in badWords)
            {
                if (message.Contains(badword))
                {
                    string newValue = "";

                    for (int i = 0; i < badword.Length; i++)
                    {
                        newValue += "*";
                    }

                    message = message.Replace(badword, newValue);

                }
            }

            return message;

        }
    }
}


