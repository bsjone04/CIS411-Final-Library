using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIS411_Final_Library.Startup))]
namespace CIS411_Final_Library
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
