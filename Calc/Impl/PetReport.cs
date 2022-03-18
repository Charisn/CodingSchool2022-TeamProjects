using PetShopLib.Enums;
using PetShopLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl
{
    internal class PetReport : IPetReport
    {
        public int Year { get; set; }
        public short Month { get; set; }
        public int TotalSold { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }

        public PetReport()
        {

        }
    }
}
