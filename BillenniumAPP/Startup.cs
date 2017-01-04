using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillenniumAPP.Startup))]
namespace BillenniumAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
