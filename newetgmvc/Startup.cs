using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(newetgmvc.Startup))]
namespace newetgmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
