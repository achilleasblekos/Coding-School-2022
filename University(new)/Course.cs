﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_new
{
    public class Course
    {
        public Guid CourseID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }


        public Course() 
        {
            
        }
            public List<Course> courses = new List<Course>();
        

        
    }
}