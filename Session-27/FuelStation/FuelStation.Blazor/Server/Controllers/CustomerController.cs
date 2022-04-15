using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListViewModel>> Get()
        {
            var result = await _customerRepo.GetAllAsync();
            return result.Select(x => new CustomerListViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber,
            });
        }

        [HttpGet("{id}")]
        public async Task<CustomerEditViewModel> Get(int id)
        {
            CustomerEditViewModel model = new();
            if (id != 0)
            {
                var foundCustomer = await _customerRepo.GetByIdAsync(id);
                model.ID = foundCustomer.ID;
                model.Name = foundCustomer.Name;
                model.Surname = foundCustomer.Surname;
                model.CardNumber = foundCustomer.CardNumber;
            }
            return model;
        }

        [HttpPost]
        public async Task Post(CustomerEditViewModel customer)
        {
            var newCustomer = new Customer()
            {
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber,

            };
            await _customerRepo.Create(newCustomer);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _customerRepo.Delete(id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CustomerEditViewModel customer)
        {
            var customerToUpdate = await _customerRepo.GetByIdAsync(customer.ID);
            if (customerToUpdate == null) return NotFound();
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Surname = customer.Surname;
            customerToUpdate.CardNumber = customer.CardNumber;

            await _customerRepo.Update(customer.ID, customerToUpdate);
            return Ok();
        }
    }
}
