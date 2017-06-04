using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NETMVCExample1.Startup))]
namespace ASP.NETMVCExample1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
