using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mediunion_2.Startup))]
namespace mediunion_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
