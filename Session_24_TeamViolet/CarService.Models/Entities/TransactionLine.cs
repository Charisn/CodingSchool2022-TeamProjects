using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities;

public class TransactionLine : BaseEntity
{
    public Guid TransactionID { get; set; }
    public Guid ServiceTaskID { get; set; }
    public Guid EngineerID { get; set; }
    public decimal Hours { get; set; }
    public decimal PricePerHour { get; set; } = 44.5m;
    public decimal Price { get; set; }
    public Transaction Transaction { get; set; }
    public ServiceTask ServiceTask { get; set; }
    public Engineer Engineer { get; set; }
}
