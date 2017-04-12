using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScrumHotelsWebApp.Startup))]
namespace ScrumHotelsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
