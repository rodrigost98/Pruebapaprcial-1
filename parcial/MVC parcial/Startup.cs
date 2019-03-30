using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_parcial.Startup))]
namespace MVC_parcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
