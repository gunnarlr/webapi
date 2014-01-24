using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firstWebApi.Startup))]
namespace firstWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
