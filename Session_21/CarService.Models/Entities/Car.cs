using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarService.Models.Entities.Enumerations;

namespace CarService.Models.Entities;

public class Car : EntityStatus
{
    public Guid Id { get; set; }
    public BrandEnum Brand { get; set; }

    public string Model { get; set; }

    public int RegistrationNumber { get; set; }

    public Car()
    {
        Id = Guid.NewGuid();
    }
}
