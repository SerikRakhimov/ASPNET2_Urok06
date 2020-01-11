using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiniInstagramWithAuth.Startup))]
namespace MiniInstagramWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
