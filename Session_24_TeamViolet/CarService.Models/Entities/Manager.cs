using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Manager : PersonWithTransaction
{
    public decimal SalaryPerMonth { get; set; }

    public List<Engineer> Engineers { get; set; } = new List<Engineer>() { };
}
