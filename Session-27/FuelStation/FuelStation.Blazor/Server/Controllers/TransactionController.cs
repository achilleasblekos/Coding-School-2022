using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Model.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly TransactionHandler _transactionHandler;
        public TransactionController(IEntityRepo<Transaction> transactionRepo, TransactionHandler transactionHandler, IEntityRepo<Item> itemRepo)
        {
            _transactionRepo = transactionRepo;
            _transactionHandler = transactionHandler;
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListViewModel>> Get()
        {
            var results = await _transactionRepo.GetAllAsync();
            return results.Select(x => new TransactionListViewModel
            {
                ID = x.ID,
                Date = x.Date,
                Customer = $"{x.Customer?.Surname} {x.Customer?.Name}",
                Employee = $"{x.Employee?.Surname} {x.Employee?.Name}",
                PaymentMethod = x.PaymentMethod,
                TotalValue = x.TotalValue,
            });
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditViewModel> Get(int id)
        {
            TransactionEditViewModel viewModel = new TransactionEditViewModel();
            if (id != 0)
            {
                var existing = await _transactionRepo.GetByIdAsync(id);
                viewModel.ID = existing.ID;
                viewModel.Date = existing.Date;
                viewModel.CustomerID = existing.CustomerID;
                viewModel.EmployeeID = existing.EmployeeID;
                viewModel.PaymentMethod = existing.PaymentMethod;
                viewModel.TotalValue = existing.TotalValue;
                viewModel.TransactionLines = existing.TransactionLines.Select(transactionLine => new TransactionLineEditViewModel
                {
                    ID = transactionLine.ID,
                    ItemID = transactionLine.ItemID,
                    Quantity = transactionLine.Quantity,
                    DiscountPercent = transactionLine.DiscountPercent,
                }).ToList();

                var items = await _itemRepo.GetAllAsync();
                viewModel.Items = items.Select(x => new ItemEditViewModel
                {
                    ID = x.ID,
                    Code = x.Code,
                    Description = x.Description,
                    Cost = x.Cost,
                    Price = x.Price,
                    ItemType = x.ItemType
                }).ToList();
            }
            return viewModel;
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _transactionRepo.Delete(id);
        }

        [HttpPost]
        public async Task Post(TransactionEditViewModel transaction)
        {
            var newTransaction = new Transaction()
            {
                Date = transaction.Date,
                CustomerID = transaction.CustomerID,
                EmployeeID = transaction.EmployeeID,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue,
            };
            await _transactionRepo.Create(newTransaction);
        }
    }
}
