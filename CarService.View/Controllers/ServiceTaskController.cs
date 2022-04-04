using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;

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
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Code", "Description", "Hours")] ServiceTask serviceTask)
        {
            if (ModelState.IsValid)
            {
                _serviceTaskRepo.CreateAsync(serviceTask);
            }
            
            return RedirectToAction(nameof(Index));
        }

        // GET: ServiceTaskController1/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var serTask = _serviceTaskRepo.GetByIdAsync(id).Result;
            return View(serTask);
        }

        // POST: ServiceTaskController1/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid id, [Bind("Code", "Description", "Hours")] ServiceTask serviceTask)
        {
            await _serviceTaskRepo.UpdateAsync(id, serviceTask);
            return RedirectToAction(nameof(Index));
        }

        // GET: ServiceTaskController1/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            return View(await _serviceTaskRepo.GetByIdAsync(id));
        }

        // POST: ServiceTaskController1/Delete/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            _serviceTaskRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
