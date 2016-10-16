using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHOMEWORK.Startup))]
namespace MVCHOMEWORK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
