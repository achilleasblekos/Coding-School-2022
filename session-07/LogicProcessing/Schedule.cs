using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    [Serializable]
    public class Schedule : DataItem
    {
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }

        public Schedule()
        {

        }
    }
}
