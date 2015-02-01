using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crowdsourcing.Domain.Entity;

namespace Crowdsourcing.Data
{
    public class CrowdsourcingContext : DbContext
    {
        public CrowdsourcingContext()
            : base("Name=DefaultConnection") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<EnterpriseManager> EnterprisesManagers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
