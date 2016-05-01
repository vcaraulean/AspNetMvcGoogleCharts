using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCharts.Startup))]
namespace MvcCharts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
