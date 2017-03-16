using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cardiodata.Web.Startup))]
namespace Cardiodata.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
