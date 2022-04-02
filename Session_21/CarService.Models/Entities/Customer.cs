using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Customer : EntityStatus
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string Surname { get; set; }

    public string FullName{get{return $"{Name} {Surname}";} set{FullName = $"{Name} {Surname}";}}

    public string Phone { get; set; }

    public string TIN { get; set; }
    public Customer()
    {
        Id = Guid.NewGuid();
    }

}
