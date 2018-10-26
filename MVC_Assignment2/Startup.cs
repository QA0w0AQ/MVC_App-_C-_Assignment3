using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Assignment2.Startup))]
namespace MVC_Assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
