using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    [Serializable]
    public class PetShop
    {
        public List<Customer> Customers { get; set; }
        public List<Pet> Pets { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Employee> Employees { get; set; }
        public List<PetFood> PetFoods { get; set; }


        public PetShop()
        {
            Customers = new List<Customer>();
            Pets = new List<Pet>();
            Transactions = new List<Transaction>();
            Employees = new List<Employee>();
            PetFoods = new List<PetFood>();
        }
    }
}
