using CarService.EF.Context;
using CarService.EF.Repositories;
using CarService.Models.Entities;
using CarService.View.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarService.View.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly CarServiceContext _context;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly TransactionLine _transactionLine;
        public TransactionController(IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo)
        {
            _transactionRepo = transactionRepo;
            _managerRepo = managerRepo;
            _customerRepo = customerRepo;
            _carRepo = carRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
        }

        // GET: CarController
        public async Task<IActionResult> Index()
        {
            return View(await _transactionRepo.GetAllAsync());
        }

        // GET: CarController/Create
        public async Task<IActionResult> Create()
        {
            var cars = await _carRepo.GetAllAsync();
            var managers = await _managerRepo.GetAllAsync();
            var customers = await _customerRepo.GetAllAsync();
            var transactionCreateView = new TransactionCreateViewModel();
            transactionCreateView.Cars = cars;
            transactionCreateView.Managers = managers;
            transactionCreateView.Customers = customers;
            return View(transactionCreateView);
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionLines","CarID", "ManagerID", "CustomerID")] TransactionViewModel transactionView)
        {
            if (!ModelState.IsValid)
            {
                return View(transactionView);
            }
            var car = await _carRepo.GetByIdAsync(transactionView.CarID);
            var manager = await _managerRepo.GetByIdAsync(transactionView.ManagerID);
            var customer = await _customerRepo.GetByIdAsync(transactionView.CustomerID);
            var transaction = new Transaction()
            {
                CarID = car.ID,
                ManagerID = manager.ID,
                CustomerID = customer.ID
            };

            transaction.TransactionLines = new List<TransactionLine>() { };

            decimal totalPrice = 0m;
            foreach (var line in transactionView.TransactionLines)
            {
                var transLine = new TransactionLine()
                {
                    Hours = line.ServiceTask.Hours,
                    ServiceTaskID = line.ServiceTaskID,
                    Price = line.ServiceTask.Hours * line.PricePerHour,
                    TransactionID = transaction.ID,
                    EngineerID = line.EngineerID
                };
                totalPrice += transLine.Price;
                transaction.TransactionLines.Add(transLine);
            }
            transaction.TotalPrice = totalPrice;
            await _transactionRepo.CreateAsync(transaction);
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
                ID = transaction.ID,
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
            if (id != transaction.ID)
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
                ID = transaction.ID,
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

        [HttpPost]
        public async Task<IActionResult> NewTask([Bind("CarID", "ManagerID", "CustomerID", "SelectedTaskID", "EngineerID", "TransactionLines")] TransactionCreateViewModel transactionView)
        {
            transactionView.Cars = await _carRepo.GetAllAsync();
            transactionView.Managers = await _managerRepo.GetAllAsync();
            transactionView.Customers = await _customerRepo.GetAllAsync();
            var selectedServiceTask = await _serviceTaskRepo.GetByIdAsync(transactionView.SelectedTaskID);
            foreach (var line in transactionView.TransactionLines)
            {
                var service = await _serviceTaskRepo.GetByIdAsync(line.ServiceTaskID);
                var task = new ServiceTasksViewModel()
                {
                    Code = service.Code,
                    Hours = service.Hours,
                    Description = service.Description,
                };
                line.ServiceTaskID = service.ID;
                line.ServiceTask = task;
                line.Hours = service.Hours;
            }

            var newTransLine = new TransactionLineViewModel()
            {
                ServiceTaskID = selectedServiceTask.ID,
                ServiceTask = new ServiceTasksViewModel()
                {
                    Code = selectedServiceTask.Code,
                    Hours = selectedServiceTask.Hours,
                    Description = selectedServiceTask.Description
                },
                Hours = selectedServiceTask.Hours,
                EngineerID = transactionView.EngineerID
            };
            
            transactionView.TransactionLines.Add(newTransLine);
            return View("Create", transactionView);
        }

        [HttpPost]
        public async Task<IActionResult> AddTask([Bind("CarID", "ManagerID", "CustomerID", "TransactionLines")] TransactionCreateViewModel transactionView)
        {
            //var selectedTask = await _serviceTaskRepo.GetByIdAsync(id);
            transactionView.Cars = await _carRepo.GetAllAsync();
            transactionView.Managers = await _managerRepo.GetAllAsync();
            transactionView.Customers = await _customerRepo.GetAllAsync();
            transactionView.Engineers = await _engineerRepo.GetAllAsync();
            transactionView.ServiceTasks = await _serviceTaskRepo.GetAllAsync();
            foreach(var line in transactionView.TransactionLines)
            {
                var service = await _serviceTaskRepo.GetByIdAsync(line.ServiceTaskID);
                var task = new ServiceTasksViewModel()
                {
                    Code = service.Code,
                    Hours = service.Hours,
                    Description = service.Description,
                };
                line.ServiceTaskID = service.ID;
                line.ServiceTask = task;
                line.Hours = service.Hours;
            }

            if (transactionView.TransactionLines.Sum(x => x.Hours) > transactionView.Engineers.Count() * 8
                || transactionView.Engineers.Count() <= transactionView.TransactionLines.Count())
                return View("Create", transactionView);

            return View("NewTask", transactionView);
        }
    }
}
