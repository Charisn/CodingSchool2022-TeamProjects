﻿
using CarService.Models.Entities;

namespace CarService.View.Models;

public class TransactionViewModel
{
    public Guid Id { get; set; }
    public Guid CarID { get; set; }
    public Guid ManagerID { get; set; }
    public Guid CustomerID { get; set; }
    public List<ServiceTask> ServiceTasks { get; set; }
    public decimal TotalPrice { get; set; }
    public List<TransactionLineViewModel> TransactionLines { get; set; } = new List<TransactionLineViewModel>();
}
public class TransactionCreateViewModel
{
    public Guid CarID { get; set; }
    public Guid ManagerID { get; set; }
    public Guid CustomerID { get; set; }
    public List<ServiceTask> ServiceTasks { get; set; }
    public decimal TotalPrice { get; set; }
    public List<TransactionLineViewModel> TransactionLines { get; set; } = new List<TransactionLineViewModel>();
}
