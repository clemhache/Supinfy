using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Supinfy.Startup))]
namespace Supinfy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
