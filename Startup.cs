using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(armstrongkarate_.Startup))]
namespace armstrongkarate_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
