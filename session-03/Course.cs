using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03
{
    public class Course
    {
        Guid id = Guid.NewGuid();
        public string Code { get; set; }
        public string  Subject { get; set; }
    }



  
}


