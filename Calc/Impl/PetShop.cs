using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl
{
    [Serializable]
    public class PetShop
    {
        public List<Customer> Customers { get; set; }

        public List<Employee> Employees { get; set; }

        public List<PetFood> PetFoods { get; set; }

        public List<Pet> Pets { get; set; }

        public List<Transaction> Transactions { get; set; }

        public PetShop()
        {
            Transactions = new List<Transaction>();
            Customers = new List<Customer>();
            Employees = new List<Employee>();
            PetFoods = new List<PetFood>(); 
            Pets = new List<Pet>();

        }
    }
}
