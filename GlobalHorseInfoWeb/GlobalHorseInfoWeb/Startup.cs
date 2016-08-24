using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlobalHorseInfoWeb.Startup))]
namespace GlobalHorseInfoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
