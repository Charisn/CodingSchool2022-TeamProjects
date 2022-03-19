using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLib.Interfaces;

namespace PetShopLib.Impl
{
    internal class Transaction : ITransaction
    { 
        public Transaction()
        {
            
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

        private void CalcTotalPrice(Transaction totalPrice)
        {
            PetFoodPrice *= PetFoodQty;
            TotalPrice += PetPrice;
            totalPrice.TotalPrice = TotalPrice;
            //trans.TotalPrice = (x => x.TotalPrice);
        }
    }
}
