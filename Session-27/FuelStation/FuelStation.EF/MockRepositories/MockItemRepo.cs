using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.MockRepositories
{
    public class MockItemRepo : IEntityRepo<Item>
    {
        private List<Item> _items = new List<Item>
        {
            new Item(){ID=1, Code="123456789", Description="item1", ItemType=ItemTypeEnum.Fuel,Cost=20,Price=50},
            new Item(){ID=2, Code="987654321", Description="item2", ItemType=ItemTypeEnum.Product,Cost=20,Price=50},
            new Item(){ID=3, Code="123456456",Description="item3",ItemType=ItemTypeEnum.Service,Cost=20,Price=50},
        };
        public Task Create(Item entity)
        {
            AddLogic(entity);
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            DeleteLogic(id);
            return Task.CompletedTask;
        }

        public List<Item> GetAll()
        {
            return _items;
        }

        public Task<IEnumerable<Item>> GetAllAsync()
        {
            return Task.FromResult(_items.AsEnumerable());
        }

        public Item? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Item?> GetByIdAsync(int id)
        {
            return Task.FromResult(_items.SingleOrDefault(item => item.ID == id));
        }

        public Task Update(int id, Item entity)
        {
            UpdateLogic(id, entity);
            return Task.CompletedTask;
        }

        private void AddLogic(Item entity)
        {
            if (entity.ID != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            var lastId = _items.OrderBy(item => item.ID).Last().ID;
            entity.ID = ++lastId;
            _items.Add(entity);
        }

        private void DeleteLogic(int id)
        {
            var foundItem = _items.SingleOrDefault(item => item.ID == id);
            if (foundItem is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            _items.Remove(foundItem);
        }


        private void UpdateLogic(int id, Item entity)
        {
            var foundItem = _items.SingleOrDefault(item => item.ID == id);
            if (foundItem is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            foundItem.Price = entity.Price;
            foundItem.Cost = entity.Cost;
            foundItem.Code = entity.Code;
            foundItem.Description = entity.Description;
        }
    }
}
