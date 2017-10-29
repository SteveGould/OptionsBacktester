using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OptionsBacktester.Web.Startup))]
namespace OptionsBacktester.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
