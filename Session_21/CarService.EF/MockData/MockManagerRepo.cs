using CarService.EF.Repositories;
using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.MockData
{
    public class MockManagerRepo : IEntityRepo<Manager>
    {
        private readonly List<Manager> _managers = new List<Manager>() { new Manager()
        {
            Name = "Fotis",
            Surname = "Karas",
            Engineers = new List<Engineer>() { new Engineer()
            {
                Name = "Nikos",
                Surname = "Karaleftheris",
                SalaryPerMonth = 1000
            } },
            SalaryPerMonth = 2000
        } };

        public MockManagerRepo()
        {

        }
        public async Task CreateAsync(Manager entity)
        {
            _managers.Add(entity);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Manager>> GetAllAsync()
        {
            return _managers;
        }

        public Task<Manager?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, Manager entity)
        {
            throw new NotImplementedException();
        }
    }
}
