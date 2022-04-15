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
    public class LedgerRepo : IEntityRepo<Ledger>
    {
        private readonly FuelStationContext _context;

        public LedgerRepo(FuelStationContext context)
        {
            _context = context;
        }
        public async Task Create(Ledger entity)
        {
            _context.Ledgers.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ledger> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ledger>> GetAllAsync()
        {
            return await _context.Ledgers.ToListAsync();
        }

        public Ledger? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ledger?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Ledger entity)
        {
            var foundLedger = await _context.Ledgers.SingleOrDefaultAsync(ledger => ledger.ID == id);
            if (foundLedger == null)
                return;
            foundLedger.Date = entity.Date;
            foundLedger.Expenses = entity.Expenses;
            foundLedger.Income = entity.Income;
            foundLedger.Total = entity.Total;
            await _context.SaveChangesAsync();

        }
    }

}
