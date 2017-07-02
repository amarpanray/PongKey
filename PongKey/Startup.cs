using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PongKey.Startup))]
namespace PongKey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
