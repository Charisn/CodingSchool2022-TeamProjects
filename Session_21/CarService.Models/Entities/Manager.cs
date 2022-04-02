using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Manager
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string FullName { get { return $"{Name} {Surname}"; } set { FullName = $"{Name} {Surname}"; } }

    public int SalaryPerMonth { get; set; }

    public List<Engineer> Engineers { get; set; } = new List<Engineer>() { };

    public Manager()
    {
        Id = Guid.NewGuid();
    }
}
