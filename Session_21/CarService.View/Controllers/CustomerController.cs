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
    }
}
