using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CinemaTiket.Startup))]
namespace CinemaTiket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
