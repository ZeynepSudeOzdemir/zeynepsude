using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zeynepsude.Startup))]
namespace zeynepsude
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
