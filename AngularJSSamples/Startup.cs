using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSSamples.Startup))]
namespace AngularJSSamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
