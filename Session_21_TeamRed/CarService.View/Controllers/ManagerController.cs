using CarService.EF.Context;
using CarService.EF.Repositories;
using CarService.Models.Entities;
using CarService.View.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly CarServiceContext _context;
        public ManagerController(IEntityRepo<Manager> managerRepo)
        {
            _managerRepo = managerRepo;
        }

        // GET: CarController
        public async Task<IActionResult> Index()
        {

            var managerView = new ManagerViewModel();
            managerView.Managers = await _managerRepo.GetAllAsync();
            return View(managerView);
        }

        // GET: CarController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name", "Surname", "SalaryPerMonth")] ManagerCreateViewModel manager)
        {
            if (!ModelState.IsValid && manager.Engineers is not null)
            {
                return View(manager);
            }

            var newManager = new Manager();

            newManager.Name = manager.Name;
            newManager.Surname = manager.Surname;
            newManager.SalaryPerMonth = manager.SalaryPerMonth;

            await _managerRepo.CreateAsync(newManager);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            var manager = await _managerRepo.GetByIdAsync(id);
            if (manager == null)
            {
                return NotFound();
            }
            var managerModel = new Manager
            {
                ID = manager.ID,
                Name = manager.Name,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPerMonth
            };
            return View(managerModel);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Name", "Surname", "SalaryPerMonth")] ManagerViewModel manager)
        {
            if (id != manager.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var currentManager = await _managerRepo.GetByIdAsync(id);
                if (currentManager is null)
                    return BadRequest("Could not find this Car");
                currentManager.Name = manager.Name;
                currentManager.Surname = manager.Surname;
                currentManager.SalaryPerMonth = manager.SalaryPerMonth;
                await _managerRepo.UpdateAsync(id, currentManager);
                return RedirectToAction(nameof(Index));
            }
            return View(manager);
        }

        // GET: CarController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            var manager = await _managerRepo.GetByIdAsync(id);
            if (manager == null)
            {
                return NotFound();
            }

            var viewModel = new Manager
            {
                Name = manager.Name,
                ID = manager.ID,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPerMonth
            };
            return View(viewModel);
        }

        // POST: CarController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id, IFormCollection collection)
        {
            await _managerRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
