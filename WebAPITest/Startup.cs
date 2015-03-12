using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPITest.Startup))]
namespace WebAPITest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
