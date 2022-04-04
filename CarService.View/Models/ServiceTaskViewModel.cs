using CarService.Models.Entities;

namespace CarService.View.Models;

public class ServiceTasksViewModel
{
    public Guid TrasactionId { get; set; }

    public int Code { get; set; }

    public string Description { get; set; }

    public int Hours { get; set; }
}
public class ServiceTasksCreateViewModel
{
    public int Code { get; set; }

    public string Description { get; set; }

    public int Hours { get; set; }

    public List<ServiceTask> Tasks { get; set; }
}

public class ServiceTasksUpdateViewModel
{

    public Guid Id { get; set; }

    public int Code { get; set; }

    public string Description { get; set; }

    public int Hours { get; set; }
}

public class ServiceTasksDeleteViewModel
{

    public Guid Id { get; set; }

    public int Code { get; set; }

    public string Description { get; set; }

    public int Hours { get; set; }
}