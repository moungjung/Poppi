using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Poppi.Startup))]
namespace Poppi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
