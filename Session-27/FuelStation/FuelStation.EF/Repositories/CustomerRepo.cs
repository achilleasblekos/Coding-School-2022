using FuelStation.EF.Context;
using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly FuelStationContext _context;
        public CustomerRepo(FuelStationContext context)
        {
            _context = context;
        }
        public async Task Create(Customer entity)
        {
            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var foundCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);
            if (foundCustomer == null)
                return;
            _context.Customers.Remove(foundCustomer);
            await _context.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.AsNoTracking().ToList();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.AsNoTracking().ToListAsync();
        }

        public Customer? GetById(int id)
        {
            return _context.Customers.AsNoTracking().Where(customer => customer.ID == id).SingleOrDefault();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _context.Customers.AsNoTracking().SingleOrDefaultAsync(customer => customer.ID == id);
        }

        public async Task Update(int id, Customer entity)
        {
            var foundCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);
            if (foundCustomer is null)
                return;
            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            foundCustomer.CardNumber = entity.CardNumber;
            await _context.SaveChangesAsync();
        }
    }
}
