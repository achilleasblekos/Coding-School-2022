using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_new
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        public Student()
        {

        }



        public bool Attend(Course course, DateTime dateTime)
        {
            return true;
        }

        public bool WriteExam(Course course, DateTime dateTime)
        {
            return true;
        }
    }
}
