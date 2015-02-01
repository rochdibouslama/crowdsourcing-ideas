using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public DateTime Date { get; set; }
        public string content { get; set; }

        //foreign Key properties
        public int? CustomerId { get; set; }
        public int? IdeaId { get; set; }

        //navigation properties
        public virtual Idea Idea { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
