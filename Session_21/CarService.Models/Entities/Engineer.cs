using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Engineer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string FullName { get { return $"{Name} {Surname}"; } set { FullName = $"{Name} {Surname}"; } }
    public Guid ManagerID { get; set; }
    public int SalaryPerMonth { get; set; }
    public Engineer()
    {
        Id = Guid.NewGuid();
    }
}
