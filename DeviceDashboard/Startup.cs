using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeviceDashboard.Startup))]
namespace DeviceDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
