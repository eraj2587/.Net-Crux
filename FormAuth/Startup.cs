using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormAuth.Startup))]
namespace FormAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
