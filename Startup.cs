using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorldSkills.Startup))]
namespace WorldSkills
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
