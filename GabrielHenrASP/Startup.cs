using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GabrielHenrASP.Startup))]
namespace GabrielHenrASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
