using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FluentTester.Startup))]
namespace FluentTester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
