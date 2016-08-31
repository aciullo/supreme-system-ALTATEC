using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAlta.Startup))]
namespace WebAlta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
