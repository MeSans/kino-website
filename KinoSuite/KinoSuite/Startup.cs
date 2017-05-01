using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KinoSuite.Startup))]
namespace KinoSuite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
