using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver : Resolver
    {
        public MessageLogger Logger { get; set; }

        public ActionResolver()
        {
            Logger = new MessageLogger();
        }

        private void WriteMessage(string message)
        {
            var msg = new Message()
            {
                MessageText = message
            };
            Logger.Write(msg);
        }

        private string ConvertToBinary(int number)
        {
            string binaryNumber = string.Empty;

            // Algorithm for converting a decimal number to binary
            for (int i = 0; number > 0; i++)
            {
                binaryNumber = number % 2 + binaryNumber;
                number /= 2;
            }

            return binaryNumber;
        }


        private string Uppercase(string phrase)
        {
            string[] words = phrase.Split(' ');
            string longestWord = string.Empty;

            if (words.Length > 1)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (longestWord.Length < words[i].Length)
                    {
                        longestWord = words[i];
                    }
                }
            }

            return longestWord.ToUpper();
        }

        private string Reverse(String text)
        {
            string reversedString = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedString += text[i];
            }

            return reversedString;
        }

        public override ActionResponse Execute(ActionRequest actionRequest)
        {
            var actionResponse = new ActionResponse()
            {
                RequestID = actionRequest.RequestID
            };

            switch (actionRequest.Action)
            {
                case ActionEnum.Convert:
                    try
                    {
                        int number = Convert.ToInt32(actionRequest.Input);
                        WriteMessage("Program took the input from the Action Request");
                        actionResponse.Output = ConvertToBinary(number);
                        WriteMessage($"Converted the decimal number {number} to binary");
                    }
                    catch (Exception ex)
                    {
                        WriteMessage($"Error: {ex.Message}");
                    }
                    break;

                case ActionEnum.Uppercase:
                    try
                    {
                        string phrase = Convert.ToString(actionRequest.Input);
                        WriteMessage("Program took the input from the Action Request");
                        if (actionResponse.Output != String.Empty)
                        {
                            actionResponse.Output = Uppercase(phrase);
                            WriteMessage($"Made the longest word in the phrase Uppercase");
                        } else
                        {
                            WriteMessage($"Phrase {phrase} has only one word. Can't execute uppercase.");
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteMessage($"Error: {ex.Message}");
                    }
                    break;

                case ActionEnum.Reverse:
                    try
                    {
                        string text = Convert.ToString(actionRequest.Input);
                        WriteMessage("Program took the input from the Action Request");
                        actionResponse.Output = Reverse(text);
                        WriteMessage($"Reversed the string {text}");
                    }
                    catch (Exception ex)
                    {
                        WriteMessage($"Error: {ex.Message}");
                    }
                    break;

                default:
                    break;
            }

            WriteMessage("Returned the response object with the output back");
            return actionResponse;

        }
    }
}
