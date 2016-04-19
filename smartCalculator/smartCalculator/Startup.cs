using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(smartCalculator.Startup))]
namespace smartCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
