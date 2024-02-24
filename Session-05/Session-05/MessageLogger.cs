using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {
        private int _messagesIndex = 0;
        private const int MAX_NUM_OF_MESSAGES = 100;
        public Message[] Messages { get; set; }

        public MessageLogger()
        {
            Messages = new Message[MAX_NUM_OF_MESSAGES];
        }

        public void ReadAll()
        {
            int i = 0;
            while (Messages[i] != null && i < Messages.Length)
            {
                Console.WriteLine(Messages[i].MessageText);
                i++;
            }
        }

        public void Clear()
        {
            Messages = new Message[MAX_NUM_OF_MESSAGES];
        }

        public void Write(Message message)
        {
            Messages[_messagesIndex] = message;
            if (_messagesIndex >= MAX_NUM_OF_MESSAGES)
            {
                _messagesIndex = 0;
            }
            _messagesIndex++;
        }
    }
}
