using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OriginsQuestICO.Startup))]
namespace OriginsQuestICO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
