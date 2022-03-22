using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.DataObjects
{
    public class TransactionView
    {

        private PetShopManager _petShop { get; set; }

        public TransactionView(PetShopManager petshop)
        {
            _petShop = petshop;
        }

        public Transaction CreateView(Guid empID, Guid custId,
                                    Guid petId, decimal petPrice, Guid foodId, int qty, decimal foodPrice, decimal total)
        {

            return new Transaction()
                        {
                            EmployeeID = empID,
                            CustomerID = custId,
                            PetID = petId,
                            PetPrice = petPrice,
                            PetFoodID = foodId,
                            PetFoodQty = qty,
                            PetFoodPrice = foodPrice,
                            TotalPrice = total
                        };
        }

        private Guid FindEmployee(string id) 
        {
            return _petShop.GetEmployees().Find(x => x.ID.Equals(id)).ID;   
        }

    }
}
