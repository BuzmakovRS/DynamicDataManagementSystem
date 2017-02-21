using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicDataManagementSystem.Startup))]
namespace DynamicDataManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
