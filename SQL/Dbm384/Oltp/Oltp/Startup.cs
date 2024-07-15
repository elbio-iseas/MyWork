using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oltp.Startup))]
namespace Oltp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
