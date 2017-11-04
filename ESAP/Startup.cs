using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESAP.Startup))]
namespace ESAP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
