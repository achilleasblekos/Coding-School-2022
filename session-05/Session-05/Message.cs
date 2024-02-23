using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string MessageText { get; set; }

        public Message()
        {
            ID = Guid.NewGuid();
            MessageText = string.Empty;
        }
    }
}
