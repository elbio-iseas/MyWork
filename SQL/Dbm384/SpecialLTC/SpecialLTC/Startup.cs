using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpecialLTC.Startup))]
namespace SpecialLTC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
