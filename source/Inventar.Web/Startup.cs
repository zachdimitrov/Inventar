using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inventar.Web.Startup))]
namespace Inventar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
