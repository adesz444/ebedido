using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ebedido.Startup))]
namespace ebedido
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
