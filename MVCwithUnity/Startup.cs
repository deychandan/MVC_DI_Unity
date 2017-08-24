using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCwithUnity.Startup))]
namespace MVCwithUnity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
