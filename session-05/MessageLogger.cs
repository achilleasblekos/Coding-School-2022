using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_05
{
    internal class MessageLogger
    {
        public Message[] Messages { get; set; }

        public Message[] ReadAll()
        {
            return Messages; 
        }

        public void Clear()
        {
            Messages = new Message[0];
        }


        public void Write()
        {
            Console.WriteLine(Messages);
        }













    }

} 























