using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLib.Interfaces;

namespace PetShopLib.Impl
{
    
    public class Transaction : ITransaction 
    {
       private MonthlyLedger _monthlyLedger = new MonthlyLedger();

        public Transaction(Guid customerID, Guid employeeID, Guid petID, decimal petPrice, Guid petFoodID, int petFoodQty, decimal petFoodPrice, decimal totalPrice) : this()
        {
            CustomerID = customerID;
            EmployeeID = employeeID;
            PetID = petID;
            PetPrice = petPrice;
            PetFoodID = petFoodID;
            PetFoodQty = petFoodQty;
            PetFoodPrice = petFoodPrice;
            TotalPrice =  totalPrice;
        }

        public Transaction()
        {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
        }

        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PetID { get; set; }
        public Guid PetFoodID { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid ID { get; set; }
    }   
}
