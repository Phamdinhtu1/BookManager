using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bt_tuan3.Startup))]
namespace bt_tuan3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
