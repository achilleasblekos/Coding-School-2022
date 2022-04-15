using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListViewModel>> Get()
        {
            var result = await _employeeRepo.GetAllAsync();
            return result.Select(x => new EmployeeListViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                EmployeeType = x.EmployeeType,
                SalaryPerMonth = x.SalaryPerMonth,
                HireDateStart = x.HireDateStart,
                HireDateEnd = x.HireDateEnd,
            });
        }

        [HttpGet("{id}")]
        public async Task<EmployeeEditViewModel> Get(int id)
        {
            EmployeeEditViewModel model = new();
            if (id != 0)
            {
                var foundEmployee = await _employeeRepo.GetByIdAsync(id);
                model.ID = foundEmployee.ID;
                model.Name = foundEmployee.Name;
                model.Surname = foundEmployee.Surname;
                model.SalaryPerMonth = foundEmployee.SalaryPerMonth;
                model.HireDateStart = foundEmployee.HireDateStart;
                model.HireDateEnd = foundEmployee.HireDateEnd;
                model.EmployeeType = foundEmployee.EmployeeType;
            }
            return model;
        }

        [HttpPost]
        public async Task Post(EmployeeEditViewModel employee)
        {
            var newEmployee = new Employee()
            {
                Name = employee.Name,
                Surname = employee.Surname,
                SalaryPerMonth = employee.SalaryPerMonth,
                EmployeeType = employee.EmployeeType,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
            };
            await _employeeRepo.Create(newEmployee);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _employeeRepo.Delete(id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EmployeeEditViewModel employee)
        {
            var employeeToUpdate = await _employeeRepo.GetByIdAsync(employee.ID);
            if (employeeToUpdate == null) return NotFound();
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Surname = employee.Surname;
            employeeToUpdate.SalaryPerMonth = employee.SalaryPerMonth;
            employeeToUpdate.EmployeeType = employee.EmployeeType;
            employeeToUpdate.HireDateStart = employee.HireDateStart;
            employeeToUpdate.HireDateEnd = employee.HireDateEnd;

            await _employeeRepo.Update(employee.ID, employeeToUpdate);
            return Ok();
        }
    }
}

