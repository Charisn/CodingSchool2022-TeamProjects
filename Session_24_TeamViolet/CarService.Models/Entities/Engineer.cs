using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Engineer : Person
{
    public Guid ManagerID { get; set; }
    public decimal SalaryPerMonth { get; set; }
    public Manager Manager { get; set; }

    //Relations
    public List<TransactionLine> TransactionLines { get; set; }
}
