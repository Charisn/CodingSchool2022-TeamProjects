using CarService.Models.Entities;

namespace CarService.View.Models;

public class CarListViewModel
{
    public Guid Id { get; set; }
    public BrandEnum Brand { get; set; }
    public string Model { get; set; }
    public int RegistrationNumber { get; set; }
}
public class CarCreateViewModel
{
    public Guid Id { get; set; }
    public BrandEnum Brand { get; set; }
    public string Model { get; set; }
    public int RegistrationNumber { get; set; }
}

public class CarUpdateViewModel
{
    public Guid Id { get; set; }
    public BrandEnum Brand { get; set; }
    public string Model { get; set; }
    public int RegistrationNumber { get; set; }
}

public class CarDeleteViewModel
{
    public Guid Id { get; set; }
    public BrandEnum Brand { get; set; }
    public string Model { get; set; }
    public int RegistrationNumber { get; set; }
}
