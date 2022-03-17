﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl
{
    public class PetShop
    {
        public List<Customer> Customers { get; set; }

        public List<Employee> Employees { get; set; }

        public List<PetFood> PetFoods { get; set; }

        public List<Pet> Pets { get; set; }
      
    }
}
