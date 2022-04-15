using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;
        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get()
        {
            var result = await _itemRepo.GetAllAsync();
            return result.Select(x => new ItemListViewModel
            {
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                Cost = x.Cost,
                Price = x.Price,
                ItemType = x.ItemType,
            });
        }
        [HttpGet("{id}")]
        public async Task<ItemEditViewModel> Get(int id)
        {
            ItemEditViewModel model = new ItemEditViewModel();
            if (id != 0)
            {
                var foundItem = await _itemRepo.GetByIdAsync(id);
                model.ID = foundItem.ID;
                model.Code = foundItem.Code;
                model.Description = foundItem.Description;
                model.Cost = foundItem.Cost;
                model.Price = foundItem.Price;
                model.ItemType = foundItem.ItemType;
            }
            return model;
        }

        [HttpPost]
        public async Task Post(ItemEditViewModel item)
        {
            var newItem = new Item()
            {
                Code = item.Code,
                Description = item.Description,
                Cost = item.Cost,
                Price = item.Price,
                ItemType = item.ItemType
            };

            await _itemRepo.Create(newItem);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _itemRepo.Delete(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemEditViewModel item)
        {
            var itemToUpdate = await _itemRepo.GetByIdAsync(item.ID);
            if (itemToUpdate == null) return NotFound();

            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.Cost = item.Cost;
            itemToUpdate.Price = item.Price;
            itemToUpdate.ItemType = item.ItemType;

            await _itemRepo.Update(item.ID, itemToUpdate);
            return Ok();
        }
    }
}
