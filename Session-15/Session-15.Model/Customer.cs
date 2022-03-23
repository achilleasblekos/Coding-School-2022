using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15.Model
{
    public class Customer : Person
    {
        public string PhoneNumber { get; set; }
        public string Tin { get; set; }

        public Customer()
        {

        }

        public Customer(string name, string surname, string phoneNumber, string tin) : base(name, surname)
        {
            PhoneNumber = phoneNumber;
            Tin = tin;

        }
    }
}
