using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class Transaction
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public Guid CarID { get; set; }
    public Guid ManagerID { get; set; }
    public Guid CustomerID { get; set; }
    public decimal TotalPrice { get; set; }
    public Manager Manager { get; set; }
    public Car Car { get; set; }
    public Customer customer { get; set; } 
    public List<TransactionLine> TransactionLines { get; set; }
    public Transaction()
    {
        Id = Guid.NewGuid();
    }
}
