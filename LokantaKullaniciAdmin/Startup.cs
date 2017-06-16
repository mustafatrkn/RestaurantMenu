using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LokantaKullaniciAdmin.Startup))]
namespace LokantaKullaniciAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
