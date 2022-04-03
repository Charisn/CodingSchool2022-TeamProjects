﻿using CarService.Models.Entities;

namespace CarService.View.Models;

public class TransactionLineViewModel
{
    public Guid Id { get; set; }
    public Guid TransactionId { get; set; }
    public Guid ServiceTaskID { get; set; }
    public Guid EngineerID { get; set; }
    public int Hours { get; set; }
    public decimal PricePerHour { get; set; } = 44.5m;
    public decimal Price { get; set; }
}
public class TransactionLineCreateViewModel
{
    public Guid TransactionId { get; set; }
    public Guid ServiceTaskID { get; set; }
    public Guid EngineerID { get; set; }
    public int Hours { get; set; }
    public decimal PricePerHour { get; set; } = 44.5m;
    public decimal Price { get; set; }
}
