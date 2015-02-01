using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entity
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string LogoURL { get; set; }
        public string ImageURL { get; set; }
        public string WelcomeText { get; set; }
        public string TemplateColor { get; set; }
        public string FormatText { get; set; }

        //foreign Key properties
        public int EnterpriseManagerId { get; set; }

        //navigation properties         
        public virtual EnterpriseManager EnterpriseManager { get; set; }
    }
}
