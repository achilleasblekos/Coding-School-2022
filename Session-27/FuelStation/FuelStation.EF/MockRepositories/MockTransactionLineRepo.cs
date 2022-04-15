using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.MockRepositories
{
    public class MockTransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public Task Create(TransactionLine entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TransactionLine> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransactionLine>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public TransactionLine? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionLine?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, TransactionLine entity)
        {
            throw new NotImplementedException();
        }
    }
}
