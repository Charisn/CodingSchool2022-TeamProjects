using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Session_24_TeamViolet.Shared.ViewModels;

namespace Session_24_TeamViolet.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController {
        private IEntityRepo<Transaction> _transactionRepo;
        private IEntityRepo<TransactionLine> _translinesRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<TransactionLine>  translinesRepo) {
            _transactionRepo = transactionRepo;
            _translinesRepo = translinesRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionViewModel>> Get() {
            var result = await _transactionRepo.GetAllAsync();

            return result.Select(x => new TransactionViewModel
            {
                Id = x.ID,
                CustomerID = x.CustomerID,
                CarID = x.CarID,
                ManagerID = x.ManagerID,
                TotalPrice = x.TotalPrice,
                Date=x.Date
            });
        }

        [HttpGet("create/{Id}")]
        public async Task<TransactionCreateViewModel> GetCreate(Guid Id) {

            TransactionCreateViewModel model = new();
            //if (id is not null) {
            //    //Edit ?
            //}
            return model;
        }



        [HttpPost]
        public async Task Post(TransactionCreateViewModel transactionViewModel) {
            var dbTrans = new Transaction()
            {
                Date = DateTime.Now,
                CarID = transactionViewModel.CarID,
                CustomerID = transactionViewModel.CustomerID,
                ManagerID = transactionViewModel.ManagerID,
                TotalPrice = transactionViewModel.TotalPrice,
                TransactionLines = new()               
            };
            foreach (var line in transactionViewModel.TransactionLines) {
                var dbLine = new TransactionLine()
                {
                    EngineerID = line.EngineerID,
                    ServiceTaskID = line.ServiceTaskID,
                    Hours = line.Hours,
                    Price = line.Price,
                    PricePerHour = line.PricePerHour
                };

                dbTrans.TransactionLines.Add(dbLine);

            }
            await _transactionRepo.CreateAsync(dbTrans);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            await _transactionRepo.DeleteAsync(id);
        }

    }
}
