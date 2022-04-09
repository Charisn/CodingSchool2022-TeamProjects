using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Session_24_TeamViolet.Shared;

namespace Session_24_TeamViolet.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase {

        private readonly IEntityRepo<Car> _carRepo;
        public CarsController(IEntityRepo<Car> carRepo) {
            _carRepo = carRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CarViewModel>> GetActiveCars() {
            var result = await _carRepo.GetAllAsync();

            return result.FindAll(x=>x.Status==true).Select(x => new CarViewModel
            {
                ID = x.ID,
                Brand = x.Brand,
                Model = x.Model,
                RegNum = x.RegistrationNumber,
                Status= x.Status
            });
        }

        [HttpGet("getall")]
        public async Task<IEnumerable<CarViewModel>> GetAllCars() {
            var result = await _carRepo.GetAllAsync();

            return result.Select(x => new CarViewModel
            {
                ID = x.ID,
                Brand = x.Brand,
                Model = x.Model,
                RegNum = x.RegistrationNumber,
                Status = x.Status
            });
        }




        [HttpPost]
        public async Task Post(CarViewModel car) {
            var dbCar = new Car()
            {
                ID = car.ID,
                Brand = car.Brand,
                Model = car.Model,
                RegistrationNumber = car.RegNum
            };
            await _carRepo.CreateAsync(dbCar);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {

            var car = await _carRepo.GetByIdAsync(id);
            car.Status = !car.Status;
            await _carRepo.UpdateAsync(id, car);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CarViewModel car) {
            var dbCar = await _carRepo.GetByIdAsync(car.ID);
            if (dbCar == null) return NotFound();
            dbCar.ID = car.ID;
            dbCar.Brand = car.Brand;
            dbCar.Model = car.Model;
            dbCar.RegistrationNumber = car.RegNum;
            await _carRepo.UpdateAsync(car.ID, dbCar);
            return Ok();
        }

    }
}
