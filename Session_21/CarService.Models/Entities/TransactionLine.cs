using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class TransactionLine
{
    public Guid Id { get; set; }
    public Guid TransactionId { get; set; }
    public Guid ServiceTaskID { get; set; }
    public Guid EngineerID { get; set; }
    public int Hours { get; set; }
    public decimal PricePerHour { get; set; }
    public decimal Price { get; set; }
    public ServiceTask ServiceTask { get; set; }
    public Engineer Engineer { get; set; }
    public TransactionLine()
    {
        Id = Guid.NewGuid();
    }
}
