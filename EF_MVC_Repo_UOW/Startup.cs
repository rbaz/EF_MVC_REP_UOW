using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(manageProjects.Startup))]
namespace manageProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
