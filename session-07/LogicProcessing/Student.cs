using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    [Serializable]
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }
        public Student()
        {
            Courses = new List<Course>();
        }
    }
}
