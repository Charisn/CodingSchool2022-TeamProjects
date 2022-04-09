using CarService.EF.Context;
using CarService.EF.Repositories;
using CarService.Models.Entities;
using CarService.View.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarService.View.Controllers
{
    public class EngineerController : Controller
    {
        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly CarServiceContext _context;
        private readonly IEntityRepo<Manager> _managerRepo;
        public EngineerController(IEntityRepo<Engineer> engineerRepo, IEntityRepo<Manager> managerRepo)
        {
            _engineerRepo = engineerRepo;
            _managerRepo = managerRepo;
        }

        // GET: CarController
        public async Task<IActionResult> Index()
        {
            var engineerView = new EngineerViewModel();
            engineerView.Engineers = await _engineerRepo.GetAllAsync();
            engineerView.ManagerList = await _managerRepo.GetAllAsync();
            return View(engineerView);
        }

        // GET: CarController/Create
        public async Task<IActionResult> Create()
        {
            var engineerView = new EngineerCreateViewModel();
            engineerView.ManagerList = await _managerRepo.GetAllAsync();
            return View(engineerView);
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name", "Surname", "SalaryPerMonth", "ManagerID")] EngineerCreateViewModel engineer)
        {
            if (!ModelState.IsValid && engineer.ManagerList is not null)
            {
                return View(engineer);
            }

            var newEngineer = new Engineer();
            newEngineer.Name = engineer.Name;
            newEngineer.Surname = engineer.Surname;
            newEngineer.SalaryPerMonth = engineer.SalaryPerMonth;
            newEngineer.ManagerID = engineer.ManagerID;
            await _engineerRepo.CreateAsync(newEngineer);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            var customer = await _engineerRepo.GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            var customerModel = new Engineer
            {
                ID = customer.ID,
                Name = customer.Name,
                Surname = customer.Surname,
                SalaryPerMonth = customer.SalaryPerMonth,
                ManagerID = customer.ManagerID
            };
            return View(customerModel);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id", "Name", "Surname", "SalaryPerMonth", "ManagerID")] EngineerViewModel engineer)
        {
            if (id != engineer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var currentEngineer = await _engineerRepo.GetByIdAsync(id);
                if (currentEngineer is null)
                    return BadRequest("Could not find this Engineer");
                currentEngineer.Name = engineer.Name;
                currentEngineer.Surname = engineer.Surname;
                currentEngineer.SalaryPerMonth = engineer.SalaryPerMonth;
                //currentEngineer.ManagerID = engineer.ManagerID;
                await _engineerRepo.UpdateAsync(id, currentEngineer);
                return RedirectToAction(nameof(Index));
            }
            return View(engineer);
        }

        // GET: CarController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            var engineer = await _engineerRepo.GetByIdAsync(id);
            var manager = await _managerRepo.GetByIdAsync(engineer.ManagerID);
            if (engineer == null)                           
            {
                return NotFound();
            }

            var viewModel = new Engineer
            {
                ID = engineer.ID,
                Name = engineer.Name,
                SalaryPerMonth = engineer.SalaryPerMonth,
                Surname = engineer.Surname,
                //Engineer = manager.Engineers.Find(engineer => engineer.Id == id) AUTO TO BAZW EDW SE PERIPTWSH POY H BASH META TO DELETE KRATAEI TO ENTRY MANAGERS.ENGINEER
            };
            return View(viewModel);
        }

        // POST: CarController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id, IFormCollection collection)
        {
            await _engineerRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
