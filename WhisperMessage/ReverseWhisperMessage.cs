using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhisperMessage
{
    public class ReverseWhisperMessage : IWhisperString
    {
        public string ManipulateMessage(string message)
        {
            if (message == null)
                throw new ArgumentNullException("The message is not valid");
            if (message.Trim().Equals(""))
                throw new ArgumentException("The message is empty");

            string[] reversedString = message.Split(' ');
            string result = "";

            foreach (var w in reversedString)
            {
                for (int i = w.Length -1; i >= 0; i--)
                {
                    if (Char.IsUpper(w[w.Length - 1 - i]))
                        result += w[i].ToString().ToUpper();
                    if (Char.IsLower(w[w.Length - 1 - i]))
                        result += w[i].ToString().ToLower();
                }
                result += " ";
            }
            return result.Trim();
        }
    }
}
