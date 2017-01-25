using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JCropMVC.Startup))]
namespace JCropMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
