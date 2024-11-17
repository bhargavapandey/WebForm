using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormAD.Startup))]
namespace WebFormAD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
