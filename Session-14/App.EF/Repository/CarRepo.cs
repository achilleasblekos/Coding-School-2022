using App.EF.Context;
using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.Repository
{
    public class CarRepo : IEntityRepo<Car>
    {
        public async Task Create(Car entity)
        {
            using var context = new MyAppContext();
            context.Cars.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new MyAppContext();
            var foundCar = context.Cars.SingleOrDefault(car => car.ID == id);
            if (foundCar is null)
                return;
            context.Cars.Remove(foundCar);
            await context.SaveChangesAsync();
        }

        public List<Car> GetAll()
        {
            using var context = new MyAppContext();
            return context.Cars.ToList();
        }

        public Car? GetById(Guid id)
        {
            using var context = new MyAppContext();
            return context.Cars.Where(car => car.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Car entity)
        {
            using var context = new MyAppContext();
            var foundCar = context.Cars.SingleOrDefault(car => car.ID == id);
            if (foundCar is null)
                return;
            foundCar.Brand = entity.Brand;
            foundCar.Model = entity.Model;
            foundCar.CarRegNumber = entity.CarRegNumber;
            await context.SaveChangesAsync();
        }
    }
}
