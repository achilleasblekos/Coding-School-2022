using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    [Serializable]
    public class Transaction : Item
    {
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }
        public Guid CarID { get; set; }
        public Car Car { get; set; }
        public Guid ManagerID { get; set; }
        public Manager Manager { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }

        
        
        


        public Transaction()
        {
            TransactionLines = new List<TransactionLine>();
            Date = DateTime.Now;
        }
    }
}
