using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    [Serializable]
    public class Institute : DataItem
    {
        public string Name { get; set; }
        public int YearsInService { get; set; }

        public Institute()
        {

        }
    }
}
