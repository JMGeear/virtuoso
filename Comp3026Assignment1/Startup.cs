using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comp3026Assignment1.Startup))]
namespace Comp3026Assignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
