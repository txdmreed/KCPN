using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KCPN.UI.MVC.Startup))]
namespace KCPN.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
