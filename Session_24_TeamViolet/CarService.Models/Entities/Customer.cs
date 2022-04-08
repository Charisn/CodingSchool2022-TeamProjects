using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Customer : PersonWithTransaction
{
    public string Phone { get; set; }

    public string TIN { get; set; }

}
