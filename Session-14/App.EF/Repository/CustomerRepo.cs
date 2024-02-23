using App.EF.Context;
using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.Repository
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public async Task Create(Customer entity)
        {
            using var context = new MyAppContext();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new MyAppContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;
            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            using var context = new MyAppContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(Guid id)
        {
            using var context = new MyAppContext();
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Customer entity)
        {
            using var context = new MyAppContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;
            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            foundCustomer.TIN = entity.TIN;
            foundCustomer.Phone = entity.Phone;
            await context.SaveChangesAsync();
        }
    }
}
