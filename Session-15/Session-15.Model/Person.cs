using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15.Model
{
    public interface IPerson
    { 
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; }
    }


    public class Person : CurrentStatus, IPerson
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get => $"{Name} {Surname}"; }//oxi mesa edo

        public Person()
        {

        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
