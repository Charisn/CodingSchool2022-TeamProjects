using PetShopLib.Enums;
using PetShopLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl
{
    public class PetReport : IPetReport
    {
        public short Year { get; set; }
        public short Month { get; set; }
        public int TotalSold { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }

        public PetReport()
        {
            //Pet = new Pet();
        }

        //public List<Pet> PetSold { get; set; }
        //edw 8elw na kanw kataxwrhsh mias listas apo to transaction
    }
}
