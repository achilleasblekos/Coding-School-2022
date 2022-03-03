using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03
{
    public class University
    {
        public string Students { get; set; }

        public string  Courses { get; set; }
        public int Grades { get; set; }

        public string Schedule { get; set; }

    }



    public string GetStudens(string student)
    {
        return student;
    }

    public string GetCourses(string course)
    {
        return course;
    }

    public int GetGrades(int grade)
    {
        return grade;
    }

    public string GetSchedule(string courseID, professorID, DateTime)
    {
        return ;
    }

    public class professorID
    {
    }
}
