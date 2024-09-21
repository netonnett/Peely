using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Peelyyy.Startup))]
namespace Peelyyy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
