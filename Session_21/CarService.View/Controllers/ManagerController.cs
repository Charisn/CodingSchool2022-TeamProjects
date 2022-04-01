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
            try
            {
                _managerRepo.CreateAsync(manager);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManagerController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManagerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ManagerController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManagerController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
