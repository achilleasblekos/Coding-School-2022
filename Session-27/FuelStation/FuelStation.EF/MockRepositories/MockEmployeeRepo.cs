using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.MockRepositories
{
    public class MockEmployeeRepo : IEntityRepo<Employee>
    {
        private List<Employee> _employees = new List<Employee>
        {
            new Employee(){ID = 1, Name ="Takis",Surname="Manageridis",EmployeeType=EmployeeTypeEnum.Manager, SalaryPerMonth=2000,HireDateStart=DateTime.Now},
            new Employee(){ID = 2, Name ="Akis",Surname="Staffikis",EmployeeType=EmployeeTypeEnum.Staff, SalaryPerMonth=450.60,HireDateStart=DateTime.Now}
        };
        public Task Create(Employee entity)
        {
            _employees.Add(entity);
            return Task.CompletedTask;

        }
        public Task Delete(int id)
        {
            DeleteLogic(id);
            return Task.CompletedTask;


        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            return Task.FromResult(_employees.AsEnumerable());
        }

        public Employee? GetById(int id)
        {
            return _employees.SingleOrDefault(employee => employee.ID == id);
        }

        public Task<Employee?> GetByIdAsync(int id)
        {
            return Task.FromResult(_employees.SingleOrDefault(employee => employee.ID == id));
        }

        public Task Update(int id, Employee entity)
        {
            UpdateLogic(id, entity);
            return Task.CompletedTask;
        }

        private void AddLogic(Employee entity)
        {
            if (entity.ID != 0)
            {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }
            var lastId = _employees.OrderBy(employee => employee.ID).Last().ID;
            entity.ID = ++lastId;
            _employees.Add(entity);
        }
        private void UpdateLogic(int id, Employee entity)
        {
            var foundEmployee = _employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.EmployeeType = entity.EmployeeType;
            foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
        }
        private void DeleteLogic(int id)
        {
            var foundEmployee = _employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            _employees.Remove(foundEmployee);
        }
    }
}
