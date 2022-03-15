using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_new
{
    public class Professor : Person
    {
        public List<Professor> Professors { get; set; }
        public string Rank { get; set; }
        public Course[] Courses { get; set; }

        public Professor()
        {

        }

        public bool Teach(Course course, DateTime dateTime)
        {
            return true;
        }
        public string SetGrade(Student studentID, Course courseID, Grade grade)
        {
            return grade.ToString();
        }
    }
}
