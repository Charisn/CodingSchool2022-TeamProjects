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


        public IActionResult Index()
        {
            return View();
        }
    }
}
