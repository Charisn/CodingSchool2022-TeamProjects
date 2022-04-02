using CarService.EF.Context;
using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly CarServiceContext _context;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly TransactionLine _transactionLine;
        public TransactionController(IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
            _managerRepo = managerRepo;
            _customerRepo = customerRepo;
            _carRepo = carRepo;
        }

        // GET: CarController
        public async Task<IActionResult> Index()
        {
            return View(await _transactionRepo.GetAllAsync());
        }

        // GET: CarController/Create
        public async Task<IActionResult> Create()
        {
            var cars = new CarRepo().GetAllAsync().Result;
            var managers = new ManagerRepo().GetAllAsync().Result;
            var customers = new CustomerRepo().GetAllAsync().Result;
            ViewData["cars"] = cars;
            ViewData["managers"] = managers;
            ViewData["customers"] = customers;
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id", "Manager", "Car", "Customer", "TransactionLine", "TotalPrice")] Transaction transaction)
        {
            if (!ModelState.IsValid)// GIATI MPAINEIS MESA EDW????????????????????????????????????????????????????? TI 8ES APO TH ZWH MOU? :P
            {
                var NewTransaction = new Transaction();

                await _transactionRepo.CreateAsync(NewTransaction);
                return RedirectToAction(nameof(Index));
            }
            _transactionRepo.CreateAsync(transaction);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _transactionRepo.GetByIdAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            var transactionModel = new Transaction
            {
                Id = transaction.Id,
                Manager = transaction.Manager,
                Customer = transaction.Customer,
                Car = transaction.Car,
                TransactionLines = transaction.TransactionLines             
            };
            return View(transactionModel);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id", "Manager", "Car", "Customer", "TransactionLine", "TotalPrice", "Date")] Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var currentTransaction = await _transactionRepo.GetByIdAsync(id);
                if (currentTransaction is null)
                    return BadRequest("Could not find this Car");
                currentTransaction.Manager = transaction.Manager;
                currentTransaction.Customer = transaction.Customer;
                currentTransaction.Car = transaction.Car;
                currentTransaction.TransactionLines = transaction.TransactionLines;
                currentTransaction.TotalPrice = transaction.TotalPrice;
                await _transactionRepo.UpdateAsync(id, currentTransaction);
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }

        // GET: CarController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _transactionRepo.GetByIdAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }

            var viewModel = new Transaction
            {
                Id = transaction.Id,
                Manager = transaction.Manager,
                Customer = transaction.Customer,
                Car = transaction.Car,
                TransactionLines = transaction.TransactionLines
            };
            return View(viewModel);
        }

        // POST: CarController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id, IFormCollection collection)
        {
            await _transactionRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
