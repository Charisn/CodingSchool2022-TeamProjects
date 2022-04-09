using CarService.EF.Context;
using CarService.EF.Repositories;
using CarService.Models.Entities;
using CarService.View.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly CarServiceContext _context;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        // GET: CarController
        public async Task<IActionResult> Index()
        {
            var customerView = new CustomerViewModel();
            customerView.Customers = await _customerRepo.GetAllAsync();
            return View(customerView);
        }

        // GET: CarController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name", "Surname","Phone", "TIN")] CustomerCreateViewModel customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }

            var newCustomer = new Customer();
            newCustomer.Name = customer.Name;
            newCustomer.Surname = customer.Surname;
            newCustomer.Phone = customer.Phone;
            newCustomer.TIN = customer.TIN;
            await _customerRepo.CreateAsync(newCustomer);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            var customer = await _customerRepo.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            var customerModel = new Customer
            {
                ID = customer.ID,
                Name = customer.Name,
                Surname = customer.Surname,
                TIN = customer.TIN
            };
            return View(customerModel);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Name", "Surname", "Phone", "TIN")] CustomerViewModel customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var currentCustomer = await _customerRepo.GetByIdAsync(id);
                if (currentCustomer is null)
                    return BadRequest("Could not find this Car");
                currentCustomer.Name = customer.Name;
                currentCustomer.Surname = customer.Surname;
                currentCustomer.TIN = customer.TIN;
                await _customerRepo.UpdateAsync(id, currentCustomer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: CarController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            var customer = await _customerRepo.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            var viewModel = new Customer
            {
                Name = customer.Name,
                ID = customer.ID,
                Surname = customer.Surname,
                TIN = customer.TIN
            };
            return View(viewModel);
        }

        // POST: CarController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id, IFormCollection collection)
        {
            await _customerRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
