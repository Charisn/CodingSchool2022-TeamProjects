using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Car : BaseEntity
{
    public BrandEnum Brand { get; set; }

    public string Model { get; set; }

    public string RegistrationNumber { get; set; }
    public List<Transaction> Transcations { get; set; }
}
