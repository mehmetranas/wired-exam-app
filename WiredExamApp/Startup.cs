using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WiredExamApp.Startup))]
namespace WiredExamApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
