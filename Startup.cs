using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crudemvc.Startup))]
namespace crudemvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
