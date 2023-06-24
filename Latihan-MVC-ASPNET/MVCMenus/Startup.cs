using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMenus.Startup))]
namespace MVCMenus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
