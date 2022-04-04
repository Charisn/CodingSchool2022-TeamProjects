using CarService.Models.Entities;

namespace CarService.View.Models;

public class CarViewModel
{
    public Guid Id { get; set; }
    public BrandEnum Brand { get; set; }
    public string Model { get; set; }
    public string RegistrationNumber { get; set; }
}
public class CarCreateViewModel
{
    public BrandEnum Brand { get; set; }
    public string Model { get; set; }
    public string RegistrationNumber { get; set; }
}

public class CarUpdateViewModel
{
    public Guid Id { get; set; }
    public BrandEnum Brand { get; set; }
    public string Model { get; set; }
    public string RegistrationNumber { get; set; }
}

public class CarDeleteViewModel
{
    public Guid Id { get; set; }
    public BrandEnum Brand { get; set; }
    public string Model { get; set; }
    public string RegistrationNumber { get; set; }
}
