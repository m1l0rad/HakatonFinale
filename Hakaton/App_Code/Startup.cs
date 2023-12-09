using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hakaton.Startup))]
namespace Hakaton
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
