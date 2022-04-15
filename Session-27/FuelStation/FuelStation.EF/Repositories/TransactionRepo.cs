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
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly FuelStationContext _context;
        public TransactionRepo(FuelStationContext context)
        {
            _context = context;
        }
        public async Task Create(Transaction entity)
        {
            _context.Transactions.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var foundTransaction = await _context.Transactions.SingleOrDefaultAsync(transaction => transaction.ID == id);
            if (foundTransaction == null)
                return;
            _context.Transactions.Remove(foundTransaction);
            await _context.SaveChangesAsync();
        }

        public List<Transaction> GetAll()
        {
            return _context.Transactions.Include(transaction => transaction.TransactionLines).ToList();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _context.Transactions.AsNoTracking().Include(transaction => transaction.Customer).Include(transaction => transaction.Employee).Include(transaction => transaction.TransactionLines).ThenInclude(transactionLine => transactionLine.Item).ToListAsync();
        }

        public Transaction? GetById(int id)
        {
            return _context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
        }

        public async Task<Transaction?> GetByIdAsync(int id)
        {
            return await _context.Transactions.AsNoTracking().Include(x => x.Customer).Include(x => x.Employee).Include(x => x.TransactionLines).ThenInclude(transactionLine => transactionLine.Item).SingleOrDefaultAsync(transaction => transaction.ID == id);
        }

        public async Task Update(int id, Transaction entity)
        {
            var foundTransaction = await _context.Transactions.Include(transaction => transaction.TransactionLines).Include(transaction => transaction.Customer).Include(transaction => transaction.Employee).SingleOrDefaultAsync(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;
            foundTransaction.Date = entity.Date;
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.EmployeeID = entity.EmployeeID;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.TotalValue = entity.TotalValue;
            foundTransaction.TransactionLines = entity.TransactionLines;
            await _context.SaveChangesAsync();
        }
    }
}
