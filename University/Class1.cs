using University;

namespace University
{
    [Serializable]
    public class Person
    {
        Guid id = Guid.NewGuid();
        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {
            Person person = new Person();
            person.Age = 7;
            person.Name = "Hector";
        }


        public string GetName()
        {
            return Name;
        }

        public string SetName()
        {
            return Name;
        }


    }


    [Serializable]
    public class Professor : Person
    {
        public List<Person> Professors { get; set; }
        public string Rank { get; set; }
        public Courses[] Courses { get; set; }
        

        public Professor()
        {
            Person professor = new Person();    
            professor.Age = 7;
            professor.Name = "Hector";
        }

        public bool Teach(Course course, DateTime dateTime)
        {
            return true;
        }


        public string SetGrade(Student studentID, Course courseID, Grade grade)
        {
            return grade.ToString();

        }






        public class Student : Person
        {
            public Courses[] Courses { get; set; }
            public int RegistrationNumber { get; set; }


            public Student()
            {

            }

            public bool Attend(Course course, DateTime dateTime)
            {
                return false;

            }

            public bool WriteExam(Course course, DateTime dateTime)
            {

                return true;
            }


        }


        public class Grade
        {
            Guid id = Guid.NewGuid();
            Guid StudentId = Guid.NewGuid();
            Guid CourseId = Guid.NewGuid();
            private int grade;

            public int GetGrade()
            {
                return grade;
            }

            public void SetGrade(int value)
            {
                grade = value;
            }

            public Grade(int grade)
            {
                SetGrade(grade);
            }
        }



        public class Course
        {
            Guid id = Guid.NewGuid();
            public string Code { get; set; }
            public string Subject { get; set; }
            public Course()
            {

            }

        }



        public class Schedule
        {
            Guid id = Guid.NewGuid();
            Guid CourseId = Guid.NewGuid();
            Guid ProfessorId = Guid.NewGuid();
            public Schedule()
            {

            }
        }
    }
}








 
 





