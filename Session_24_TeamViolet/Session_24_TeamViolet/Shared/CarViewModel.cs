using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_24_TeamViolet.Shared {
    public class CarViewModel {

        public Guid ID { get; set; }
        public BrandEnum Brand { get; set; }
        public string Model { get; set; }
        public string RegNum { get; set; }
        public bool Status { get; set; }




    }
}
