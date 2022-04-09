using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_24_TeamViolet.Shared;
using Session_24_TeamViolet.Shared.ViewModels;

namespace Session_24_TeamViolet.Server.Controllers;


[ApiController]
[Route("[controller]")]
public class EngineerController : ControllerBase
{
    private readonly IEntityRepo<Engineer> _engineerRepo;
    private readonly IEntityRepo<Manager> _managerRepo;
    public EngineerController(IEntityRepo<Engineer> engineerRepo, IEntityRepo<Manager> managerRepo)
    {
        _engineerRepo = engineerRepo;
        _managerRepo = managerRepo;
    }

    [HttpGet]
    public async Task<IEnumerable<EngineerViewModel>> GetEngineers()
    {        
        var result = await _engineerRepo.GetAllAsync();
        return result.FindAll(x => x.Status == true).Select(x => new EngineerViewModel
        {
            ID = x.ID,
            Name = x.Name,
            Surname = x.Surname,
            SalaryPerMonth = x.SalaryPerMonth,
            ManagerID = x.ManagerID,
            Status = x.Status
        });
    }

    [HttpGet("getallengineers")]
    public async Task<IEnumerable<EngineerViewModel>> GetAllEngineers()
    {
        var result = await _engineerRepo.GetAllAsync();
        return result.Select(x => new EngineerViewModel
        {
            ID = x.ID,
            Name = x.Name,
            Surname = x.Surname,
            SalaryPerMonth = x.SalaryPerMonth,
            ManagerID = x.ManagerID,
            Status = x.Status
        });
    }

    [HttpPost]
    public async Task PostEngineers(EngineerViewModel engineer)
    {
        var newEngineer = new Engineer();
        newEngineer.ID = engineer.ID;
        newEngineer.Name = engineer.Name;
        newEngineer.Surname = engineer.Surname;
        newEngineer.SalaryPerMonth = engineer.SalaryPerMonth;
        newEngineer.ManagerID = engineer.ManagerID;
        await _engineerRepo.CreateAsync(newEngineer);
    }

    [HttpDelete("{ID}")]
    public async Task DeleteEngineers(Guid id)
    {
        
        var _engineer = await _engineerRepo.GetByIdAsync(id);
        _engineer.Status = !_engineer.Status;
        await _engineerRepo.UpdateAsync(id , _engineer);
    }

    [HttpPut]
    public async Task<ActionResult> Put(EngineerViewModel engineer)
    {
        var engineerToUpdate = await _engineerRepo.GetByIdAsync(engineer.ID);
        if (engineerToUpdate == null) return NotFound();

        engineerToUpdate.Name = engineer.Name;
        engineerToUpdate.Surname = engineer.Surname;
        engineerToUpdate.SalaryPerMonth = engineer.SalaryPerMonth;
        engineerToUpdate.ManagerID = engineer.ManagerID;
        await _engineerRepo.UpdateAsync(engineer.ID , engineerToUpdate);

        return Ok();
    }
}
