using Microsoft.AspNetCore.Http;
using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using CarService.EF.Context;
using CarService.View.Models;

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

        // GET: CarController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Brand", "Model", "RegistrationNumber")] CarCreateViewModel car)
        {
            if (!ModelState.IsValid)
            {
                return View(car);
            }

            var newCar = new Car();
            newCar.Brand = car.Brand;
            newCar.Model = car.Model;
            newCar.RegistrationNumber = car.RegistrationNumber;
            await _carRepo.CreateAsync(newCar);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            var car = await _carRepo.GetByIdAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            var carModel = new Car
            {
                ID = car.ID,
                Brand = car.Brand,
                Model = car.Model,
                RegistrationNumber = car.RegistrationNumber
            };
            return View(carModel);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id", "Brand", "Model", "RegistrationNumber")] CarViewModel car) 
        {
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var currentCar = await _carRepo.GetByIdAsync(id);
                if (currentCar is null)
                    return BadRequest("Could not find this Car");
                currentCar.RegistrationNumber = car.RegistrationNumber;
                currentCar.Brand = car.Brand;
                currentCar.Model = car.Model;
                await _carRepo.UpdateAsync(id, currentCar);
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: CarController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            var car = await _carRepo.GetByIdAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            var viewModel = new Car
            {
                Brand = car.Brand,
                ID = car.ID,
                Model = car.Model,
                RegistrationNumber = car.RegistrationNumber
            };
            return View(viewModel);
        }

        // POST: CarController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id, IFormCollection collection)
        {
            await _carRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
