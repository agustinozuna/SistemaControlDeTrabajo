using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaControlDeTrabajo.Startup))]
namespace SistemaControlDeTrabajo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
