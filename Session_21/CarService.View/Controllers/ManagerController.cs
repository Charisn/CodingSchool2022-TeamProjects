using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IEntityRepo<Manager> _managerRepo;

        public ManagerController(IEntityRepo<Manager> managerRepo)
        {
            _managerRepo = managerRepo;
        }
        // GET: ManagerController1
        public async Task<ActionResult>  Index()
        {
            return View(await _managerRepo.GetAllAsync());
        }

        // GET: ManagerController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManagerController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Name", "Surname", "SalaryPerMonth")]Manager manager)
        {
            await _managerRepo.CreateAsync(manager);
            return RedirectToAction(nameof(Index));
        }

        // GET: ManagerController1/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            return View(await _managerRepo.GetByIdAsync(id));
        }

        // POST: ManagerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid id, [Bind("Name", "Surname", "SalaryPerMonth")] Manager manager)
        {
            if (ModelState.IsValid)
            {
                await _managerRepo.UpdateAsync(id, manager);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ManagerController1/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            return View(await _managerRepo.GetByIdAsync(id));
        }

        // POST: ManagerController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id, [Bind("Name", "Surname", "SalaryPerMonth")] Manager manager)
        {
            await _managerRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));            
        }
    }
}
