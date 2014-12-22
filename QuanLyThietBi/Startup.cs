using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyThietBi.Startup))]
namespace QuanLyThietBi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
