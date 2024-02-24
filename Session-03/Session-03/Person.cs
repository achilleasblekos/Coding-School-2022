using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Person
    {
        public Guid ID { get; }
        public string Name;
        public int Age { get; set; }

        public Person()
        {
            ID = Guid.NewGuid();
            // Initializing the string properties so they won't be Null
            Name = "";

        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
