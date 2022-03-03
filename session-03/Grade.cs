using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03
{
    public class Grade
    {
        public int Grade { get; set; }

        public Grade(int grade)
        {
            Grade = grade;
        }

        Guid id = Guid.NewGuid();
        Guid StudentId = Guid.NewGuid();
        Guid CourseId = Guid.NewGuid();

       
    }




}
