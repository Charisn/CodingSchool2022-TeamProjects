using PetShopLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl
{
    public class Customer : ICustomer
    {
        public long Phone { get ; set; }
        public int TIN { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public Guid ID { get; set; }
        public Customer()
        {
            ID = Guid.NewGuid();
        }
    }

}
