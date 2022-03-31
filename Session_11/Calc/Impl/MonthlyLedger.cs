using PetShopLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetShopLib.Impl
{
    public class MonthlyLedger : IMonthlyLedger
    {
        private const short RENTING_COST = 2000;
        private const string FILE_NAME = "PetShop.json";


        
        private PetShop _petShop;

        public short Year { get; set; }
        public short Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; } 
        
        public List<Transaction> Transactions { get; set; } 

        public MonthlyLedger()
        {
            //_petShop = PopulatePetShop();
        }

        //public PetShop PopulatePetShop()
        //{
        //    if (File.Exists(FILE_NAME))
        //    {
        //        string s = File.ReadAllText(FILE_NAME);
        //        var petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));
        //        return petShop;
        //    }
            
        //}

        public decimal CalculateIncome()
        {
            decimal total_cost = 0;
            foreach (var item in Transactions)
            {
                Income += item.TotalPrice;
            }

            return Income;
        }

        public decimal CalculateExpenses()
        {
            Expenses = RENTING_COST + CalculatePetCost() +CalculatePetFoodCost() + CalculateSalaries() ;
            return Expenses;
        }

        public decimal CalculateTotal()
        {
             Total = CalculateIncome() - CalculateExpenses() ;
            return Total;
        }

        public decimal CalculateSalaries()
        {
            decimal total_SalaryCost = 0;
            foreach (var item in _petShop.Employees)
            {
                total_SalaryCost += item.SalaryPerMonth;

            }

            return total_SalaryCost;
        }

        public decimal CalculatePetCost()
        {
            decimal total_petCost = 0;
            foreach (var item in _petShop.Pets)
            {
                total_petCost += item.Cost;

            }

            return total_petCost;
        }

        public decimal CalculatePetFoodCost()
        {
            decimal total_petFoodCost = 0;
            foreach (var item in _petShop.PetFoods)
            {
                total_petFoodCost += item.Cost;

            }

            return total_petFoodCost;
        }

       

     

        //public void GetReport(int month,int year)
        //{

        //}
    }
}
