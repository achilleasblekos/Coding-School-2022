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
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly FuelStationContext _context;
        public ItemRepo(FuelStationContext context)
        {
            _context = context;
        }
        public async Task Create(Item entity)
        {
            _context.Items.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var foundItem = await _context.Items.SingleOrDefaultAsync(item => item.ID == id);
            if (foundItem == null)
                return;
            _context.Items.Remove(foundItem);
            await _context.SaveChangesAsync();
        }

        public List<Item> GetAll()
        {
            return _context.Items.ToList();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _context.Items.AsNoTracking().ToListAsync();
        }

        public Item? GetById(int id)
        {
            return _context.Items.Where(item => item.ID == id).SingleOrDefault();
        }

        public async Task<Item?> GetByIdAsync(int id)
        {
            return await _context.Items.AsNoTracking().SingleOrDefaultAsync(item => item.ID == id);
        }

        public async Task Update(int id, Item entity)
        {
            var foundItem = await _context.Items.SingleOrDefaultAsync(item => item.ID == id);
            if (foundItem is null)
                return;
            foundItem.Cost = entity.Cost;
            foundItem.Price = entity.Price;
            foundItem.Code = entity.Code;
            foundItem.Description = entity.Description;
            foundItem.ItemType = entity.ItemType;
            await _context.SaveChangesAsync();

        }
    }
}
