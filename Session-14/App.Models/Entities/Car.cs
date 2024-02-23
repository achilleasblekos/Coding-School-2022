using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    [Serializable]
    public class Car : Item
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarRegNumber { get; set; }
        public string FullName { get; }
        public Car()
        {
            Brand = string.Empty;
            Model = string.Empty;
            CarRegNumber = string.Empty;
            FullName = $"{Brand} {Model}";
        }
    }
}
