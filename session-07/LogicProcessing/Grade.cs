using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    [Serializable]
    public class Grade : DataItem
    {
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Value { get; set; }

        public Grade()
        {

        }
    }
}
