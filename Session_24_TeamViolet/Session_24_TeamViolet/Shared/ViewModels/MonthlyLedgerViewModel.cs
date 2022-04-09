using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_24_TeamViolet.Shared.ViewModels;

public class MonthlyLedgerViewModel
{
    public short Year { get; set; }
    public sbyte Month { get; set; }
    public decimal Income { get; set; }
    public decimal Expenses { get; set; }
    public decimal Total { get; set; }

    public ManagerViewModel Manager { get; set; }
    public EngineerViewModel Engineer { get; set; }
    public ServiceTaskViewModel ServiceTask { get; set; }

    public MonthEnum monthEnum { get; set; }
}
