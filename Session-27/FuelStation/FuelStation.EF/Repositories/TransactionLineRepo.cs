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
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        private readonly FuelStationContext _context;
        public TransactionLineRepo(FuelStationContext context)
        {
            _context = context;
        }
        public async Task Create(TransactionLine entity)
        {
            _context.TransactionLines.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var foundTransactionLine = await _context.TransactionLines.SingleOrDefaultAsync(transactionLine => transactionLine.ID == id);
            if (foundTransactionLine == null)
                return;
            _context.TransactionLines.Remove(foundTransactionLine);
            await _context.SaveChangesAsync();
        }

        public List<TransactionLine> GetAll()
        {
            return _context.TransactionLines.ToList();
        }

        public async Task<IEnumerable<TransactionLine>> GetAllAsync()
        {
            return await _context.TransactionLines.Include(transactionLine => transactionLine.Item).Include(transactionLine => transactionLine.Transaction).ToListAsync();
        }

        public TransactionLine? GetById(int id)
        {
            return _context.TransactionLines.Where(transactionLine => transactionLine.ID == id).SingleOrDefault();
        }

        public async Task<TransactionLine?> GetByIdAsync(int id)
        {
            return await _context.TransactionLines.Include(x => x.Item).Include(x => x.Transaction).SingleOrDefaultAsync(transactionLine => transactionLine.ID == id);
        }

        public async Task Update(int id, TransactionLine entity)
        {
            var foundTransactionLine = await _context.TransactionLines.SingleOrDefaultAsync(transactionLine => transactionLine.ID == id);
            if (foundTransactionLine is null)
                return;
            foundTransactionLine.Quantity = entity.Quantity;
            foundTransactionLine.ItemPrice = entity.ItemPrice;
            foundTransactionLine.NetValue = entity.NetValue;
            foundTransactionLine.DiscountPercent = entity.DiscountPercent;
            foundTransactionLine.DiscountValue = entity.DiscountValue;
            foundTransactionLine.TotalValue = entity.TotalValue;
            foundTransactionLine.ItemID = entity.ItemID;
            foundTransactionLine.TransactionID = entity.TransactionID;
            await _context.SaveChangesAsync();
        }
    }
}
