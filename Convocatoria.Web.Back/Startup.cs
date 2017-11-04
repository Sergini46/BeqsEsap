using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Convocatoria.Web.Back.Startup))]
namespace Convocatoria.Web.Back
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
