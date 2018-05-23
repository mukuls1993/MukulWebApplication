using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MukulWebApplication.Startup))]
namespace MukulWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
