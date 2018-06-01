using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wisbo_ErpSystem.Startup))]
namespace Wisbo_ErpSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
