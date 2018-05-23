using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBarberShopTemplate.Startup))]
namespace TheBarberShopTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
