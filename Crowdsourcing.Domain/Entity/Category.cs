    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }         
        public string Name { get; set; }         
        
        //navigation properties         
        virtual public ICollection<Product> Products { get; set; }
        virtual public ICollection<Idea> Ideas { get; set; }
    }
}
