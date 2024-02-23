using App.EF.Context;
using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.Repository
{
    public class ManagerRepo : IEntityRepo<Manager>
    {
        public async Task Create(Manager entity)
        {
            using var context = new MyAppContext();
            context.Managers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new MyAppContext();
            var foundManager = context.Managers.SingleOrDefault(manager => manager.ID == id);
            if (foundManager is null)
                return;
            context.Managers.Remove(foundManager);
            await context.SaveChangesAsync();
        }

        public List<Manager> GetAll()
        {
            using var context = new MyAppContext();
            return context.Managers.ToList();
        }

        public Manager? GetById(Guid id)
        {
            using var context = new MyAppContext();
            return context.Managers.Where(manager => manager.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Manager entity)
        {
            using var context = new MyAppContext();
            var foundManager = context.Managers.SingleOrDefault(manager => manager.ID == id);
            if (foundManager is null)
                return;
            foundManager.Name = entity.Name;
            foundManager.Surname = entity.Surname;
            foundManager.SallaryPerMonth = entity.SallaryPerMonth;
            await context.SaveChangesAsync();
        }
    }
}
