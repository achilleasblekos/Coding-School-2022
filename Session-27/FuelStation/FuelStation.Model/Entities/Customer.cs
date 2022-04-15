using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class Customer : Person
    {

        public string CardNumber { get; set; }

        public Customer()
        {

        }
        //entity Frame
        public List<Transaction>? Transactions { get; set; }
    }
}
