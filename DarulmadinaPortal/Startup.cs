using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DarulmadinaPortal.Startup))]
namespace DarulmadinaPortal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
