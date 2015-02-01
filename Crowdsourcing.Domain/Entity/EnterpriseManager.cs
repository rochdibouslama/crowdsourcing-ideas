using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entity
{
    public class EnterpriseManager
    {
        public int EnterpriseManagerId { get; set; }
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

        //navigation properties         
        public virtual ICollection<Project> Projects { get; set; }
        virtual public ICollection<Product> Products { get; set; }
        virtual public ICollection<Member> Member { get; set; }
        virtual public ICollection<Customer> Customer { get; set; }
    }
}
