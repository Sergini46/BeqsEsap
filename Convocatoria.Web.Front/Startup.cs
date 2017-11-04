using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Convocatoria.Web.Front.Startup))]
namespace Convocatoria.Web.Front
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
