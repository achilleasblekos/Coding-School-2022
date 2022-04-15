using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.MockRepositories
{
    public class MockTransactionRepo : IEntityRepo<Transaction>
    {
        private List<Transaction> _transactions = new List<Transaction>
        {
            new Transaction(){ID = 1, CustomerID = 1,EmployeeID=1, PaymentMethod=PaymentMethodEnum.Cash,TotalValue=100},
            new Transaction(){ID = 2, CustomerID = 2,EmployeeID=1, PaymentMethod=PaymentMethodEnum.Credit_Card,TotalValue=25},
        };

        public Task Create(Transaction entity)
        {
            AddLogic(entity);
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            DeleteLogic(id);
            return Task.CompletedTask;
        }

        public List<Transaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return Task.FromResult(_transactions.AsEnumerable());
        }

        public Transaction? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction?> GetByIdAsync(int id)
        {
            return Task.FromResult(_transactions.SingleOrDefault(transaction => transaction.ID == id));
        }

        public Task Update(int id, Transaction entity)
        {
            UpdateLogic(id, entity);
            return Task.CompletedTask;
        }

        private void AddLogic(Transaction entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            var lastId = _transactions.OrderBy(transaction => transaction.ID).Last().ID;
            entity.ID = ++lastId;
            _transactions.Add(entity);
        }

        private void DeleteLogic(int id)
        {
            var foundTransaction = _transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction != null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            _transactions.Remove(foundTransaction);
        }

        private void UpdateLogic(int id, Transaction entity)
        {
            var foundTransaction = _transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction != null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            foundTransaction.Date = entity.Date;
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.EmployeeID = entity.EmployeeID;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.TotalValue = entity.TotalValue;
        }
    }
}
