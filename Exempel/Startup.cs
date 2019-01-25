using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exempel.Startup))]
namespace Exempel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
