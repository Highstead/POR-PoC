using Microsoft.Owin;
using Owin;
using POR.API;

[assembly: OwinStartup(typeof(Startup))]
namespace POR.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
