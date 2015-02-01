using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entity
{
    public class Idea
    {
        public int IdeaId { get; set; }

        //foreign Key properties
        public int? CustomerId { get; set; }
        public int? CategoryId { get; set; }
        public int? StateId { get; set; }

        //navigation properties         
        public virtual Customer Customer { get; set; }
        virtual public ICollection<Member> Member { get; set; }
        public virtual Category Category { get; set; }
        public virtual State State { get; set; }

    }
}
