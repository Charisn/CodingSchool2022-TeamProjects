using CarService.Models.Entities;

namespace CarService.View.Models;

public class CustomerViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string Surname { get; set; }

    public string FullName => $"{Name} {Surname}";

    public string Phone { get; set; }

    public string TIN { get; set; }

    public List<Customer> Customers { get; set; }
}
public class CustomerCreateViewModel
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string FullName => $"{Name} {Surname}";

    public string Phone { get; set; }

    public string TIN { get; set; }
}

public class CustomerUpdateViewModel
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string FullName => $"{Name} {Surname}";
    public string Phone { get; set; }

    public string TIN { get; set; }
}

public class CustomerDeleteViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string Surname { get; set; }

    public string FullName => $"{Name} {Surname}";
    public string Phone { get; set; }

    public string TIN { get; set; }
}

