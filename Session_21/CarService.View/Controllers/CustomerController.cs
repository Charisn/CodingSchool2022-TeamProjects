using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _customerRepo.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name", "Surname", "Phone", "TIN")] Customer customer)
        {
            await _customerRepo.CreateAsync(customer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            return View(await _customerRepo.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id, [Bind("Name", "Surname", "Phone", "TIN")] Customer customer)
        {
            await _customerRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            return View(await _customerRepo.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("Name", "Surname", "Phone", "TIN")] Customer customer)
        {
            await _customerRepo.UpdateAsync(id, customer);
            return RedirectToAction(nameof(Index)); 
        }
    }
}
