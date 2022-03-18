using PetShopLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl
{
    internal class MonthlyLedger : IMonthlyLedger
    {
        public short Year { get; set; }
        public short Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }        

        public MonthlyLedger()
        {

        }
    }
}
