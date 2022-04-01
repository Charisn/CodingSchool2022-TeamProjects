using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class CustomerController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
