using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CobbMovieMVC5.Startup))]
namespace CobbMovieMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
