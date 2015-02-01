using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entity
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public double PhoneNumber { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public DateTime subscriptionDate { get; set; }
        public string Email { get; set; }
        public string Pseudo { get; set; }
        public string Username { get; set; }
        public string Location { get; set; }

        //foreign Key properties
        public int? EnterpriseManagerId { get; set; } // ? => nullable

        //navigation properties       
        public virtual EnterpriseManager EnterpriseManager { get; set; }
        virtual public ICollection<Idea> Idea { get; set; }
    }
}
