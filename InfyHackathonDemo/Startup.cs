using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfyHackathonDemo.Startup))]
namespace InfyHackathonDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
