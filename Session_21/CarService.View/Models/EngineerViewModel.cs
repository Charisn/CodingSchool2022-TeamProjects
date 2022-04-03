using CarService.Models.Entities;


namespace CarService.View.Models;

public class EngineerViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public List<Manager> ManagerList { get; set; }
    public List<Engineer> Engineers { get; set; }

    public Guid ManagerID { get; set; }
    public int SalaryPerMonth { get; set; }
}
public class EngineerCreateViewModel
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public List<Manager> ManagerList { get; set; }

    public Guid ManagerID { get; set; }
    public int SalaryPerMonth { get; set; }
}

public class EngineerUpdateViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public List<Manager> ManagerList { get; set; }

    public Guid ManagerID { get; set; }
    public int SalaryPerMonth { get; set; }
}

public class EngineerDeleteViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public List<Manager> ManagerList { get; set; }

    public Guid ManagerID { get; set; }
    public int SalaryPerMonth { get; set; }
}

