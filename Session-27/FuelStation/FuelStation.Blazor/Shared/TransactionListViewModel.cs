using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class TransactionListViewModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Employee { get; set; }
        public string Customer { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public double TotalValue { get; set; }
    }

    public class TransactionEditViewModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public double TotalValue { get; set; }
        public List<TransactionLineEditViewModel> TransactionLines { get; set; } = new();
        public List<ItemEditViewModel> Items { get; set; } = new();

    }
}
