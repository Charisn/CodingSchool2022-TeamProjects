using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Engineer : Person
{
    public Guid ManagerID { get; set; }
    public int SalaryPerMonth { get; set; }
}
