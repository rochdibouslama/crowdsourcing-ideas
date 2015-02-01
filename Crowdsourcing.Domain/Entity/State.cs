using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entity
{
    public class State
    {
        public int StateId { get; set; }
        public string Name { get; set; }

        //navigation properties         
        virtual public ICollection<Idea> Ideas { get; set; } 
    }
}
