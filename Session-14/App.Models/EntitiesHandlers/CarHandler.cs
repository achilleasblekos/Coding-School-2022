using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.EntitiesHandlers
{
    public class CarHandler
    {
        public CarHandler()
        {

        }

        public Car Create()
        {
            return new Car();
        }

        public void Delete(Car car, List<Car> cars)
        {
            cars.Remove(car);
        }
    }
}
