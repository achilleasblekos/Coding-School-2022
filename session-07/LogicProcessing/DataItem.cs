using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    [Serializable]
    public class DataItem
    {
        public Guid ID { get; set; }

        public DataItem()
        {
            ID = Guid.NewGuid();
        }
    }
}
