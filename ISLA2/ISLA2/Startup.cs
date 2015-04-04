using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISLA2.Startup))]
namespace ISLA2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
