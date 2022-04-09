using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Session_24_TeamViolet.Shared.ViewModels;

namespace Session_24_TeamViolet.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ManagersController : ControllerBase {

        private readonly IEntityRepo<Manager> _managerRepo;
        public ManagersController(IEntityRepo<Manager> managerRepo) {
            _managerRepo = managerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ManagerViewModel>> GetActiveManagers() {
            var result = await _managerRepo.GetAllAsync();
            return result.FindAll(x=> x.Status == true).Select(x => new ManagerViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                SalaryPerMonth = x.SalaryPerMonth,
                Status=x.Status,
            });
        }

        [HttpGet("getall")]
        public async Task<IEnumerable<ManagerViewModel>> GetAllManagers() {
            var result = await _managerRepo.GetAllAsync();
            return result.Select(x => new ManagerViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                SalaryPerMonth = x.SalaryPerMonth,
                Status = x.Status,
            });
        }
        [HttpPost]
        public async Task Post(ManagerViewModel manager) {
            var dbManager = new Manager()
            {
                ID = manager.ID,
                Name = manager.Name,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPerMonth
            };
            await _managerRepo.CreateAsync(dbManager);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            var manager = await _managerRepo.GetByIdAsync(id);
            manager.Status = !manager.Status;
            await _managerRepo.UpdateAsync(id, manager);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ManagerViewModel manager) {
            var dbManager = await _managerRepo.GetByIdAsync(manager.ID);
            if (dbManager == null) return NotFound();
            dbManager.ID = manager.ID;
            dbManager.Surname = manager.Surname;
            dbManager.Name= manager.Name;
            dbManager.SalaryPerMonth = manager.SalaryPerMonth;
            await _managerRepo.UpdateAsync(manager.ID, dbManager);
            return Ok();
        }


    }










}

