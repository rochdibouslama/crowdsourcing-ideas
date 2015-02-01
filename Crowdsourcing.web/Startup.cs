using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crowdsourcing.web.Startup))]
namespace Crowdsourcing.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
