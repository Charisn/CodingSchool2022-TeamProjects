using PetShopLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetShopLib.Interfaces
{

    internal interface IIdentifiable
    {
        Guid ID { get; set; }
    }

    internal interface ISellable
    {
        decimal Price { get; set; }
        decimal Cost { get; set; }
    }

    internal interface IPerson : IIdentifiable
    {
        string Name { get; set; }

        string SurName { get; set; }
    }

    internal interface ICustomer : IPerson
    {
        long Phone { get; set; }

        int TIN { get; set; }
    }

    internal interface IEmployee : IPerson
    {
        decimal SalaryPerMonth { get; set; }

        EmployeeTypeEnum EmployeeType { get; set; }
    }

    internal interface IAnimal
    {
        AnimalTypeEnum AnimalType { get; set; }

    }

    internal interface IPet : IAnimal, IIdentifiable, ISellable
    {
        string Breed { get; set; }

        PetStatusEnum PetStatus { get; set; }
    }

    internal interface IPetFood : IAnimal, IIdentifiable, ISellable
    {

    }

    internal interface ITransaction : IIdentifiable
    {
        DateTime Date { get; set; }

        Guid CustomerID { get; set; }

        Guid EmployeeID { get; set; }

        Guid PetID { get; set; }

        Guid PetFoodID { get; set; }

        decimal PetPrice { get; set; }

        int PetFoodQty { get; set; }

        decimal PetFoodPrice { get; set; }

        decimal TotalPrice { get; set; }

    }

    internal interface IMonthlyLedger
    {
        short Year { get; set; }

        short Month { get; set; }

        decimal Income { get; set; }

        decimal Expenses { get; set; }

        decimal Total { get; set; }
    }

    internal interface IPetReport : IAnimal
    {
        short Year { get; set; }

        short Month { get; set; }

        int TotalSold { get; set; }

    }
}
