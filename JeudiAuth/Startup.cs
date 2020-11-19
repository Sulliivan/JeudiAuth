using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JeudiAuth.Startup))]
namespace JeudiAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
