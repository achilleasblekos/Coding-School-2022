using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class Ledger : BaseEntity
    {
        public Ledger()
        {

        }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Year { get { return Date.Year; } }
        public int Month { get { return Date.Month; } }
        public double Expenses { get; set; }
        public double Income { get; set; }
        public double Total { get; set; }
    }
}
