using App.EF.Context;
using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.Repository
{
    public class EngineerRepo : IEntityRepo<Engineer>
    {
        public async Task Create(Engineer entity)
        {
            using var context = new MyAppContext();
            context.Engineers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new MyAppContext();
            var foundEngineer = context.Engineers.SingleOrDefault(engineer => engineer.ID == id);
            if (foundEngineer is null)
                return;
            context.Engineers.Remove(foundEngineer);
            await context.SaveChangesAsync();
        }

        public List<Engineer> GetAll()
        {
            using var context = new MyAppContext();
            return context.Engineers.ToList();
        }

        public Engineer? GetById(Guid id)
        {
            using var context = new MyAppContext();
            return context.Engineers.Where(engineer => engineer.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Engineer entity)
        {
            using var context = new MyAppContext();
            var foundEngineer = context.Engineers.SingleOrDefault(engineer => engineer.ID == id);
            if (foundEngineer is null)
                return;
            foundEngineer.Name = entity.Name;
            foundEngineer.Surname = entity.Surname;
            foundEngineer.SallaryPerMonth = entity.SallaryPerMonth;
            foundEngineer.ManagerID = entity.ManagerID;
            await context.SaveChangesAsync();
        }
    }
}
