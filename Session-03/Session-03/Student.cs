using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        public Student()
        {
            Courses = new Course[20];
        }

        public void Attend(Course course, DateTime datetime)
        {
            // Write functionality for attending a course
        }

        public void WriteExam(Course course, DateTime datetime)
        {
            // Write functionality for writing an exam
        }
    }
}
