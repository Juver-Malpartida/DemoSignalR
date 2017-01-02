using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoSignalR.Startup))]
namespace DemoSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
