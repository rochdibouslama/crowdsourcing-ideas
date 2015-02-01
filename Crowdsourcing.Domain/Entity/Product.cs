using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entity
{
    public class Product
    {
        public int? ProductId { get; set; } // ? => nullable

        //foreign Key properties
        public int EnterpriseManagerId { get; set; }
        public int? CategoryId { get; set; }
        //navigation properties         
        public virtual EnterpriseManager EnterpriseManager { get; set; }
        public virtual Category Category { get; set; }

    }
}
