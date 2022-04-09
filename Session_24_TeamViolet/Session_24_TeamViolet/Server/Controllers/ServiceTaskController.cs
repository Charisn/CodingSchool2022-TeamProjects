using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Session_24_TeamViolet.Shared.ViewModels;

namespace Session_24_TeamViolet.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceTaskController : ControllerBase
    {
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;

        public ServiceTaskController(IEntityRepo<ServiceTask> serviceTaskRepo)
        {
            _serviceTaskRepo = serviceTaskRepo;
        }


        [HttpGet]        
        public async Task<List<ServiceTaskViewModel>> Get()
        {
            List<ServiceTaskViewModel> serviceTaskViewModels = new List<ServiceTaskViewModel>();
            var serviceTasks = await _serviceTaskRepo.GetAllAsync();
            var activeServiceTasks = serviceTasks.Where(x => x.Status);
            if (activeServiceTasks.Any())
            {
                foreach(var task in activeServiceTasks)
                {
                    var taskViewModel = new ServiceTaskViewModel()
                    {
                        ID = task.ID,
                        Code = task.Code,
                        Description = task.Description,
                        Hours = task.Hours,
                        Status = task.Status,
                    };
                    serviceTaskViewModels.Add(taskViewModel);
                }
                return serviceTaskViewModels;
            }

            return new List<ServiceTaskViewModel>();
            
        }

        [HttpGet("inactive")]
        public async Task<List<ServiceTaskViewModel>> GetInActive()
        {
            List<ServiceTaskViewModel> serviceTaskViewModels = new List<ServiceTaskViewModel>();
            var serviceTasks = await _serviceTaskRepo.GetAllAsync();
            var inactiveServiceTasks = serviceTasks.Where(x => !x.Status);
            if (inactiveServiceTasks.Any())
            {
                foreach (var task in inactiveServiceTasks)
                {
                    var taskViewModel = new ServiceTaskViewModel()
                    {
                        ID = task.ID,
                        Code = task.Code,
                        Description = task.Description,
                        Hours = task.Hours,
                        Status = task.Status,
                    };
                    serviceTaskViewModels.Add(taskViewModel);
                }
                return serviceTaskViewModels;
            }

            return new List<ServiceTaskViewModel>();

        }

        [HttpGet("{id}")]
        public async Task<ServiceTaskViewModel> GetByIdAsync(Guid id)
        {
            var serviceTask = await _serviceTaskRepo.GetByIdAsync(id);

            if(serviceTask == null || !serviceTask.Status) return null;

            var taskView = new ServiceTaskViewModel()
            {
                ID = serviceTask.ID,
                Code= serviceTask.Code,
                Description= serviceTask.Description,
                Hours = serviceTask.Hours,
                Status = serviceTask.Status,
            };

            return taskView;
        }

        [HttpPost]
        public async Task Post([FromBody] ServiceTaskViewModel serviceTask)
        {
            if (serviceTask.Code is null || serviceTask.Description is null)
                return;

            var newServiceTask = new ServiceTask()
            {
                Code = serviceTask.Code,
                Description = serviceTask.Description,
                Hours = serviceTask.Hours,
            };

            await _serviceTaskRepo.CreateAsync(newServiceTask);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ServiceTaskViewModel taskView)
        {
            if (taskView.Code is null || taskView.Description is null)
                return NotFound();

            var serviceTask = await _serviceTaskRepo.GetByIdAsync(taskView.ID);
            if (serviceTask is null) return NotFound();

            serviceTask.Code = taskView.Code;
            serviceTask.Description = taskView.Description;
            serviceTask.Hours = taskView.Hours;
            serviceTask.Status = taskView.Status;

            await _serviceTaskRepo.UpdateAsync(taskView.ID, serviceTask);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                await _serviceTaskRepo.DeleteAsync(id);

                return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
