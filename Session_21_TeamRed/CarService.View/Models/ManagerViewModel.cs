using CarService.Models.Entities;


namespace CarService.View.Models;

public class ManagerViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<Engineer> Engineers { get; set; }
    public List<Manager> Managers { get; set; }
    public int SalaryPerMonth { get; set; }
}
public class ManagerCreateViewModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<Engineer> Engineers { get; set; }
    public int SalaryPerMonth { get; set; }
}