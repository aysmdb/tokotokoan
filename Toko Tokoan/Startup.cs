using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Toko_Tokoan.Startup))]
namespace Toko_Tokoan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
