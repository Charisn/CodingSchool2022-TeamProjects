using CarService.EF.Repositories;
using CarService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Session_24_TeamViolet.Shared;

namespace Session_24_TeamViolet.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController: ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo=customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerViewModel>> Get()
        {
            var result = await _customerRepo.GetAllAsync();

            var activecustomers = result.FindAll(x => x.Status == true);
            var t = activecustomers.Select(x => new CustomerViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Phone = x.Phone,
                TIN = x.TIN,
                Status = x.Status,
                Surname = x.Surname
                
            });

            return t;
                }
        [HttpGet("GetAllCust")]
        public async Task<IEnumerable<CustomerViewModel>> GetAll()
        {
            var result = await _customerRepo.GetAllAsync();

            var t = result.Select(x => new CustomerViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Phone = x.Phone,
                TIN = x.TIN,
                Status = x.Status,
                Surname = x.Surname

            });

            return t;
        }
        [HttpGet("GetOneCustomer{id}")]
        public async Task<CustomerViewModel> GetOne(Guid id)
        {
            var result = await _customerRepo.GetByIdAsync(id);

            var t=new CustomerViewModel
            {
                ID = result.ID,
                Name = result.Name,
                Phone = result.Phone,
                TIN = result.TIN,
                Status = result.Status,
                Surname = result.Surname

            };

            return t;
        }

        [HttpPost]

         public async Task Post(CustomerViewModel newcustomerview)
            {
                Customer customer = new Customer
                {
                    ID = newcustomerview.ID,//??
                    Name = newcustomerview.Name,
                    Surname = newcustomerview.Surname,
                    Status = newcustomerview.Status,
                    TIN = newcustomerview.TIN,
                    Phone = newcustomerview.Phone
                };
                await _customerRepo.CreateAsync(customer);
               
            }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {

          var x=  await _customerRepo.GetByIdAsync(id);
            x.Status = !x.Status;
           await _customerRepo.UpdateAsync(id,x);
        }


        [HttpPut]
        public async Task<ActionResult> Put(CustomerViewModel newcustomerview)
        {
            var customertoupdate =await _customerRepo.GetByIdAsync(newcustomerview.ID);
            if (customertoupdate == null) return NotFound();


            customertoupdate.Name = newcustomerview.Name;
            customertoupdate.Surname = newcustomerview.Surname;
            customertoupdate.Status = newcustomerview.Status;
            customertoupdate.TIN = newcustomerview.TIN;
            customertoupdate.Phone = newcustomerview.Phone;

            await _customerRepo.UpdateAsync(newcustomerview.ID, customertoupdate);



            return Ok();
        }
            
               

           
            

            
        
    }
}
