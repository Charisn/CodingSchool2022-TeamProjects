
using CarService.Models.Entities;

namespace CarService.View.Models;

public class TransactionViewModel
{
    public Guid CarID { get; set; }
    public Guid ManagerID { get; set; }
    public Guid CustomerID { get; set; }
    public List<TransactionLineViewModel> TransactionLines { get; set; } = new List<TransactionLineViewModel>();
}
public class TransactionCreateViewModel
{
    public Guid CarID { get; set; }
    public Guid ManagerID { get; set; }
    public Guid CustomerID { get; set; }
    public Guid EngineerID { get; set; }
    public List<Car> Cars { get; set; }
    public List<Customer> Customers { get; set; }
    public List<Manager> Managers { get; set; }
    public List<ServiceTask> ServiceTasks { get; set; } = new List<ServiceTask>();
    public List<Engineer> Engineers { get; set; } = new List<Engineer>();
    public Guid SelectedTaskID { get; set; }
    public decimal TotalPrice { get; set; }
    public List<TransactionLineViewModel> TransactionLines { get; set; } = new List<TransactionLineViewModel>();
}
