using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhisperMessage
{
    public class WhisperCreateCalculation : IWhisperString
    {
        
        public string ManipulateMessage(string message)
        {
            if (message == null) throw new ArgumentNullException("Message is null");
            if (message.Trim().Equals("")) throw new ArgumentException("Message is empty");

            string newMessage = "";

            string[] operators = new string[] { "+", "-", "*", "/"};

            //the operator that will be used next
            int currentOperator = 0;

            //stores the index in newMessage where the last operator was put in
            //null was hard to use so using -1 instead
            int lastOperatorIndex = -1;

            //go through all characters in message string
            for (int i = 0; i < message.Length; i++)
            {

                //add character to newMessage
                newMessage += message[i];

                //check if whitespace
                if (Char.IsWhiteSpace(message[i])) {

                    //add operator and whitespace
                    newMessage += operators[currentOperator] + " ";

                    //make next operator the next in operators
                    currentOperator ++;

                    //loop back from 3 to 0
                    currentOperator %= 4;

                    //store newMessage index of newly put in operator
                    //-1 because last object in array is one less than length
                    //-1 because there's a whitespace after the operator
                    lastOperatorIndex = newMessage.Length - 2;
                
                }

            }

            //if any operators were added
            if (lastOperatorIndex != -1) {

                //create tempCharArray based on newMessage
                char[] tempCharArray = newMessage.ToCharArray();

                //replace last operator with =
                tempCharArray[lastOperatorIndex] = '=';

                //set newMessage to tempCharArray
                newMessage = new string(tempCharArray);
            
            } 

            return newMessage;

        }
    }
}
