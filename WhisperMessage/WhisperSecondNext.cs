using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhisperMessage
{
    public class WhisperSecondNext: IWhisperString
    {

        public string ManipulateMessage(string message)
        {
            bool next = false;
            string newMessage = string.Empty;
            int inext = 0;
            if (message == null)
                throw new ArgumentNullException("Message is null.");
            if (message.Trim().Equals(""))
                throw new ArgumentException("Message is empty.");
            foreach (var letter in message)
            {
                if (!Char.IsLetter(letter)&& !Char.IsNumber(letter))
                {
                    newMessage += letter.ToString();
                    next = false;
                }
                else if (Char.IsNumber(letter))
                {
                    inext = int.Parse(letter.ToString());
                    newMessage += letter.ToString();
                }
                    else if(inext>0){
                        newMessage += nextLeter(letter,inext).ToString();
                        inext = 0;
                }
                    
                else if (next == false) {
                    
                    newMessage += letter.ToString();
                }
                else if (Char.IsLetter(letter) && next == true) {
                    
                    newMessage += nextLeter(letter,1).ToString();
                }
                if (next == false) next = true;
                else if (next == true) next = false;
            }
            return newMessage;

        }
        char nextLeter(char letter, int i) {
            char nextChar;
            if (letter == 'ö')
            {
                nextChar = 'a';
                if (i > 1) return nextLeter((char)(((int)nextChar) + 1), i - 1);
            }
           else if (letter == 'ä')
            {
                nextChar = 'ö';
                if (i > 1) return nextLeter((char)(((int)nextChar) + 1), i - 1);
            }
            else if (letter == 'å')
            {
                nextChar = 'ä';
                if (i > 1) return nextLeter((char)(((int)nextChar) + 1), i - 1);
            }
            else if (letter == 'z')
            {
                nextChar = 'å';
                if (i > 1) return nextLeter((char)(((int)nextChar) + 1), i - 1);
            }
            else if (letter == 'Ö')
            {
                nextChar = 'A';
                if (i > 1) return nextLeter((char)(((int)nextChar) + 1), i - 1);
            }
            else if (letter == 'Ä')
            {
                nextChar = 'Ö';
                if (i > 1) return nextLeter((char)(((int)nextChar) + 1), i - 1);
            }
            else if (letter == 'Å')
            {
                nextChar = 'Ä';
                if (i > 1) return nextLeter((char)(((int)nextChar) + 1), i - 1);
            }
            else if (letter == 'Z')
            {
                nextChar = 'Å';
                if (i > 1) return nextLeter((char)(((int)nextChar) + 1), i - 1);
            }
            else if (i > 1) return nextLeter((char)(((int)letter) + 1), i - 1);
            else
                nextChar = (char)(((int)letter) + 1);
            return nextChar;
        }
    }
}
