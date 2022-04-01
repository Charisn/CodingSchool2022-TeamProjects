using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class ServiceTaskController : Controller
    {
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;

        public ServiceTaskController(IEntityRepo<ServiceTask> serviceTaskRepo)
        {
           _serviceTaskRepo = serviceTaskRepo;
        }

        // GET: ServiceTaskController1
        public async Task<IActionResult> Index()
        {
            return View(await _serviceTaskRepo.GetAllAsync());
        }

        // GET: ServiceTaskController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServiceTaskController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceTaskController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ServiceTaskController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServiceTaskController1/Edit/5
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

        // GET: ServiceTaskController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServiceTaskController1/Delete/5
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
