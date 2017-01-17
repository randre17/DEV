using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyVentas.Startup))]
namespace ProyVentas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
