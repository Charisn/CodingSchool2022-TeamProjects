using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl
{
    internal class Transaction
    {
        public Guid ID { get; set; }

        public Guid CustomerID { get; set; }

        public DateTime Created { get; set; }

        public Guid EmployeeID { get; set; }

        public Guid PetID { get; set; }

        public Guid PetFoodID { get; set; }

        public int PetFoodQty { get; set; }

        public decimal PetPrice { get; set; }

        public decimal PetFoodPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public Transaction()
        {
            
        }
    }
}
