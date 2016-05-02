using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoldChallenge.Startup))]
namespace GoldChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
