using CarService.EF.Context;
using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class EngineerController : Controller
    {
        private readonly IEntityRepo<Engineer> _engineerRepo;

        public EngineerController(IEntityRepo<Engineer> engineerRepo)
        {
            _engineerRepo = engineerRepo;
        }
        public async Task<IActionResult> Create()
        {
            ViewData["Managers"] = new CarServiceContext().Managers.ToList();
            return View();
        }

        public async Task<IActionResult> Index()
        {
            return View(await _engineerRepo.GetAllAsync());
        }
    }
}
