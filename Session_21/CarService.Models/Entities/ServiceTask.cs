using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class ServiceTask
{
    public Guid Id { get; set; }

    public int Code { get; set; }

    public string Description { get; set; }

    public decimal Hours { get; set; }
    public ServiceTask()
    {
        Id = Guid.NewGuid();
    }
}
