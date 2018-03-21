using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarageSaleMY.Startup))]
namespace GarageSaleMY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
