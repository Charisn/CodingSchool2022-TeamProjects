using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_24_TeamViolet.Shared.ViewModels
{
    public class TransactionViewModel
    {
        public Guid Id { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarID { get; set; }
        public Guid ManagerID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLineViewModel> TransactionLines { get; set; }

    }


    public class TransactionCreateViewModel {
        public Guid? Id { get; set; } 
        public Guid CustomerID { get; set; }
        public Guid CarID { get; set; }
        public Guid ManagerID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLineViewModel> TransactionLines { get; set; } = new();

    }
}
