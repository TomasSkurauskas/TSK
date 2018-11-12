using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSK.Startup))]
namespace TSK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
