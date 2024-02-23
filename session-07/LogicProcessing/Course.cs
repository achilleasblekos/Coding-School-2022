using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    [Serializable]
    public class Course : DataItem
    {
        public string Code { get; set; }
        public string Subject { get; set; }

        public Course()
        {
            Code = string.Empty;
            Subject = string.Empty;
        }
    }
}
