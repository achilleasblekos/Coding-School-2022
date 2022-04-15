using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class Transaction : BaseEntity
    {
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public double TotalValue { get; set; }

        public Transaction()
        {
            Date = DateTime.Now;
            TransactionLines = new List<TransactionLine>();
        }
        //Entity Frame
        public List<TransactionLine> TransactionLines { get; set; }
        public Customer? Customer { get; set; }
        public Employee? Employee { get; set; }
    }
}
