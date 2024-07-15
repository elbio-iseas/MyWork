using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spatial.Startup))]
namespace Spatial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
