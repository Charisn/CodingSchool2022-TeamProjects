using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models.Entities
{
    public class BaseEntity
    {
        public bool Status { get; set; } = true;

        public Guid Id { get; set; }= Guid.NewGuid();
    }
}
