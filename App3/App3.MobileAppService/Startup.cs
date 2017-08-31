using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(App3.MobileAppService.Startup))]

namespace App3.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}