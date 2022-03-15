using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_new
{
    public class University1 : Institute
    {
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduleCourse { get; set; }

        public University1()
        {
           Students = new List<Student>();
           Professors = new List<Professor>(); 
           Courses = new List<Course>();
           Grades = new List<Grade>();
           ScheduleCourse = new List<Schedule>();

        }
        


        private string _student;
        private string _course;
        private string _grade;
        private string _schedule;
        private string GetStudents()
        {
            return _student;
        }

        private string GetCourses()
        {
            return _course;
        }

        private string GetGrades()
        {
            return _grade;
        }

        private string GetSchedule()
        {
            return _schedule;
        }

        public class Professor
        {
        }
    }
}
