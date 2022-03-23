using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15.Model
{
    public interface IProduct
    {
        decimal Price { get; set; }
        decimal Cost { get; set; }
        Guid ID { get; set; }
    }



    public class Product : CurrentStatus, IProduct
    {
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public Guid ID { get; set; }

        public Product()
        {
            ID = Guid.NewGuid();
        }
    }
}
