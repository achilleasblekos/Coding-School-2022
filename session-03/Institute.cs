using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03
{
    public class Institute
    {
        public string _name;
        private string name;

        public string GetName(string _name)
        {
            return _name;
        }

        public void SetName(string _name)
        {
            _name = name;
        }

        public int YearsInService { get; set; }
    }


    public Institute()
    {
        Guid id = Guid.NewGuid();
    }
}
