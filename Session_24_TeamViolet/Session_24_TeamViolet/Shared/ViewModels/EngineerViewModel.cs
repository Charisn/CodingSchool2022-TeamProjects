using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_24_TeamViolet.Shared.ViewModels;

public class EngineerViewModel
{
    public Guid ID { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    public string Surname { get; set; }

    public Guid ManagerID { get; set; }
    public decimal SalaryPerMonth { get; set; }
    public List<ManagerViewModel> Managers { get; set; } = new();
    public bool Status { get; set; } = true;

}
