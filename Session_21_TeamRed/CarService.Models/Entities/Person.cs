using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Person : BaseEntity
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string FullName => $"{Name} {Surname}";
}

public class PersonWithTransaction : Person
{
    public List<Transaction> Transactions { get; set; }
}