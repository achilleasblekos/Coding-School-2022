using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class TransactionLineListViewModel
    {
        public int ID { get; set; }
        public Item Item { get; set; }
        public double Quantity { get; set; }
        public double ItemPrice { get; set; }
        public float DiscountPercent { get; set; }
        public double TotalValue { get; set; }
    }

    public class TransactionLineEditViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public double Quantity { get; set; }
        public float DiscountPercent { get; set; }
    }
}
