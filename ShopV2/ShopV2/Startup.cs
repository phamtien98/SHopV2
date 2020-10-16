using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopV2.Startup))]
namespace ShopV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
