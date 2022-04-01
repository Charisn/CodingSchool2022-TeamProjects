using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class CarController : Controller
    {
        private readonly IEntityRepo<Car> _carRepo;

        public CarController(IEntityRepo<Car> carRepo)
        {
            _carRepo = carRepo;
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            return View(await _carRepo.GetAllAsync());
        }
    }
}
