using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_new
{
    public class Grade
    {
        public Guid Id { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grde { get; set; }


        public Grade()
        {

        }
    }
}
