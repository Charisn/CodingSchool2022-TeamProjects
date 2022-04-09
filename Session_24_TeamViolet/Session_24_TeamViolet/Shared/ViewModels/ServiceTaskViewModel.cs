using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_24_TeamViolet.Shared.ViewModels
{
    public class ServiceTaskViewModel
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }

        public bool Status { get; set; }
    }
}
