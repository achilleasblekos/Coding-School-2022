using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLibrary.DataObjects;

namespace PetShopLibrary
{
    
    public interface IPetReport
    {
        int Year { get; set; }
        string Month { get; set; }
        AnimalType Type { get; set; }

        int TotalSold { get; set; }
    }



    public class PetReport:IPetReport
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public AnimalType Type { get; set; }
        public int TotalSold { get; set; }
        

        public PetReport(int year, string month, List<Transaction> transactions)
        {
            Year = year;
            Month = month;
        }
        public PetReport()
        {

        }
    }
}
