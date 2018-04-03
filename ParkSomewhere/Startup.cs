using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParkSomewhere.Startup))]
namespace ParkSomewhere
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
