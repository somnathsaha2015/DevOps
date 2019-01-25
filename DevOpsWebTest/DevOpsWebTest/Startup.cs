using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsWebTest.Startup))]
namespace DevOpsWebTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
