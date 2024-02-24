using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {
        public Guid ID { get; }
        public int YearsInService { get; set; }
        public string Name;

        public Institute()
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
