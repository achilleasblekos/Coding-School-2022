using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class TransactionLine : BaseEntity
    {
        public int TransactionID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }
        public double NetValue { get; set; }
        public float DiscountPercent { get; set; }
        public double DiscountValue { get; set; }
        public double TotalValue { get; set; }

        public TransactionLine()
        {

        }

        //entity frame

        public Transaction? Transaction { get; set; }
        public Item? Item { get; set; }
    }
}
