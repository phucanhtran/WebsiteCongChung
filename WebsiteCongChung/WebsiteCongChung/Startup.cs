using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteCongChung.Startup))]
namespace WebsiteCongChung
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
