using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_new
{
    public class Schedule
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessosID { get; set; }
        public DateTime Callendar { get; set; }

        public Schedule()
        {

        }
    }
}
