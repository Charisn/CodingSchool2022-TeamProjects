using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Transaction
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public Guid CarID { get; set; }
    public Guid ManagerID { get; set; }
    public Guid CustomerID { get; set; }
    public decimal TotalPrice { get; set; }
    public Transaction()
    {
        Id = Guid.NewGuid();
    }
}
