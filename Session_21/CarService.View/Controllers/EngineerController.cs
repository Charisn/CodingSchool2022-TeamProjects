using CarService.EF.Context;
using CarService.EF.Repositories;
using CarService.Models.Entities;
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
            var managerList = await _managerRepo.GetAllAsync();
            ViewData["manager"] = managerList;
            return View(await _engineerRepo.GetAllAsync());
        }

        // GET: CarController/Create
        public async Task<IActionResult> Create()
        {
            var managers = new ManagerRepo().GetAllAsync().Result;
            ViewData["managers"] = managers;
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id", "Name", "Surname", "SalaryPerMonth", "ManagerID")] Engineer engineer)
        {
            if (!ModelState.IsValid)
            {
                var NewEngineer = new Engineer();

                await _engineerRepo.CreateAsync(NewEngineer);
                return RedirectToAction(nameof(Index));
            }
            _engineerRepo.CreateAsync(engineer);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engineer = await _engineerRepo.GetByIdAsync(id);
            if (engineer == null)
            {
                return NotFound();
            }
            var engineerModel = new Engineer
            {
                Id = engineer.Id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth,
                ManagerID = engineer.ManagerID
            };
            return View(engineerModel);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id", "Name", "Surname", "SalaryPerMonth", "ManagerID")] Engineer engineer)
        {
            if (id != engineer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var currentEngineer = await _engineerRepo.GetByIdAsync(id);
                if (currentEngineer is null)
                    return BadRequest("Could not find this Car");
                currentEngineer.Name = engineer.Name;
                currentEngineer.Surname = engineer.Surname;
                currentEngineer.SalaryPerMonth = engineer.SalaryPerMonth;
                await _engineerRepo.UpdateAsync(id, currentEngineer);
                return RedirectToAction(nameof(Index));
            }
            return View(engineer);
        }

        // GET: CarController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engineer = await _engineerRepo.GetByIdAsync(id);
            if (engineer == null)
            {
                return NotFound();
            }

            var viewModel = new Engineer
            {
                Id = engineer.Id,
                Name = engineer.Name,
                SalaryPerMonth = engineer.SalaryPerMonth,
                Surname = engineer.Surname
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
