namespace PetShopLibrary
{
    public interface ITransaction
    {
        Guid ID { get; }
        DateTime Date { get; }
        Guid CustomerID { get; set; }
        Guid EmployeeID { get; set; }
        Guid PetID { get; set; }
        decimal PetPrice { get; set; }
        Guid PetFoodID { get; set; }
        int PetFoodQty { get; set; }
        decimal PetFoodPrice { get; set; }
        decimal TotalPrice { get; }

    }

    public class Transaction : ITransaction
    {
        public Guid ID { get; }
        public DateTime Date { get; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PetID { get; set; }
        public decimal PetPrice { get; set; }
        public Guid PetFoodID { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }


        public Transaction()
        {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
        }

        public Transaction(Guid customerID, Guid employeeID, Guid petID, decimal petPrice, Guid petFoodID, int petFoodQty, decimal petFoodPrice) : this()
        {
            CustomerID = customerID;
            EmployeeID = employeeID;
            PetID = petID;
            PetPrice = petPrice;
            PetFoodID = petFoodID;
            PetFoodQty = petFoodQty;
            PetFoodPrice = petFoodPrice;
        }
    }
}