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
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        private readonly FuelStationContext _context;
        public EmployeeRepo(FuelStationContext context)
        {
            _context = context;
        }
        public async Task Create(Employee entity)
        {
            _context.Employees.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var foundEmployee = await _context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
            if (foundEmployee == null)
                return;
            _context.Employees.Remove(foundEmployee);
            await _context.SaveChangesAsync();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.AsNoTracking().ToListAsync();
        }

        public Employee? GetById(int id)
        {
            return _context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees.AsNoTracking().Where(employee => employee.ID == id).SingleOrDefaultAsync();
        }

        public async Task Update(int id, Employee entity)
        {
            var foundEmployee = await _context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
            if (foundEmployee is null)
                return;
            //if(!foundEmployee.HireDateEnd.HasValue)
            //{
            //    entity.HireDateEnd= DateTime.Now;
            //}
            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.EmployeeType = entity.EmployeeType;
            foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            foundEmployee.HireDateStart = entity.HireDateStart;
            foundEmployee.HireDateEnd = entity.HireDateEnd;
            await _context.SaveChangesAsync();
        }
    }
}
