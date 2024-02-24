using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    {
        public string Rank { get; set; }
        public Course[] Courses { get; set; }


        public Professor()
        {
            Courses = new Course[20];
            // Initializing the string properties so they won't be Null
            Rank = "";
        }

        new public string GetName()
        {
            return $"Dr.{Name}";
        }

        public void Teach(Course course, DateTime datetime)
        {
            // Write the functionality for the teaching
        }

        public void SetGrade(Guid studentID, Guid courseID, Grade grade)
        {
            // Write the functionality for changing the grade of a student
        }
    }
}
