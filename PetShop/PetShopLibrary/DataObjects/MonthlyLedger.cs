using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public interface IMonthlyLedger
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expences { get; set; }

        public decimal Total { get; set; }
    }
    public class MonthlyLedger : IMonthlyLedger
        {
        public int Year { get; set; }
        public string Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expences { get; set; }

        public decimal Total { get; set; }


        public MonthlyLedger()
        {

        }

        public MonthlyLedger(int year, string month, List<Transaction> transactions)
        {
            Year = year;
            Month = month;
        }
    }
}

