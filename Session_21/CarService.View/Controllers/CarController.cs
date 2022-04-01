using Microsoft.AspNetCore.Http;
using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using CarService.EF.Context;

namespace CarService.View.Controllers
{
    public class CarController : Controller
    {
        private readonly IEntityRepo<Car> _carRepo;
        private readonly CarServiceContext _context;
        public CarController(IEntityRepo<Car> carRepo)
        {
            _carRepo = carRepo;
        }

        // GET: CarController
        public async Task<IActionResult> Index()
        {
            return View(await _carRepo.GetAllAsync());
        }


        // GET: CarController/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if(id == Guid.Empty)
            {
                return View();
            }

            var car = await _carRepo.GetByIdAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            var viewModel = new Car
            {
                Brand = car.Brand,
                Model = car.Model,
                RegistrationNumber = car.RegistrationNumber
            };

            return View(viewModel);
        }

        // GET: CarController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Model")] Car car)
        {
        //    if (ModelState.IsValid)
        //    {
        //        var NewCar = new Car(car.Model);

        //        await _carRepo.AddAsync(NewCar);
        //        return RedirectToAction(nameof(Index));
        //    }
            return View(car);
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
