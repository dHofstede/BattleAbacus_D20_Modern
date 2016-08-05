using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BattleAbacus_D20_Modern.Startup))]
namespace BattleAbacus_D20_Modern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
