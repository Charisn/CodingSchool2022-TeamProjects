using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class ServiceTask : BaseEntity
{
    public string Code { get; set; }

    public string Description { get; set; }

    public int Hours { get; set; }
}
