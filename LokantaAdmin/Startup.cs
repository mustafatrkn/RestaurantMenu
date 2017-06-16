using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LokantaAdmin.Startup))]
namespace LokantaAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
