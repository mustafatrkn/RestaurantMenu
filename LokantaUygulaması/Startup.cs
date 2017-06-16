using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LokantaUygulaması.Startup))]
namespace LokantaUygulaması
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
