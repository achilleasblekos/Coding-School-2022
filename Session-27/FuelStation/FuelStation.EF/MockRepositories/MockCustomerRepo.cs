using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.MockRepositories
{
    public class MockCustomerRepo : IEntityRepo<Customer>
    {
        private List<Customer> _customers = new List<Customer>
        {
            new Customer(){ ID=1, Name="Achilleas",Surname="Mplekos",CardNumber="A123-1234-1234-1234" },
            new Customer(){ ID=2, Name="Petros",Surname="Papadopoulos",CardNumber="A123456789"},

        };
        public Task Create(Customer entity)
        {
            AddLogic(entity);
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            DeleteLogic(id);
            return Task.CompletedTask;
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            return Task.FromResult(_customers.AsEnumerable());
        }

        public Customer? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer?> GetByIdAsync(int id)
        {
            return Task.FromResult(_customers.SingleOrDefault(customer => customer.ID == id));
        }

        public Task Update(int id, Customer entity)
        {
            UpdateLogic(id, entity);
            return Task.CompletedTask;
        }
        private void AddLogic(Customer entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            var lastId = _customers.OrderBy(customer => customer.ID).Last().ID;
            entity.ID = ++lastId;
            _customers.Add(entity);
        }

        private void DeleteLogic(int id)
        {
            var foundCustomer = _customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            _customers.Remove(foundCustomer);
        }


        private void UpdateLogic(int id, Customer entity)
        {
            var foundCustomer = _customers.SingleOrDefault(todo => todo.ID == id);
            if (foundCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;

        }
    }
}
