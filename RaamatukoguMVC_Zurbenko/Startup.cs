using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaamatukoguMVC_Zurbenko.Startup))]
namespace RaamatukoguMVC_Zurbenko
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
