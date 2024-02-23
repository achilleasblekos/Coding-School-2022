using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    [Serializable]
    public class Customer : Person
    {
        public string Phone { get; set; }
        public string TIN { get; set; }

        public Customer()
        {
            Phone = string.Empty;
            TIN = string.Empty;
        }
    }
}
