using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_24_TeamViolet.Shared
{
    public class CustomerViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public bool Status { get; set; } = true;

        

        public Guid ID { get; set; }
        public string Phone { get; set; }

        public string TIN { get; set; }
    }
}
