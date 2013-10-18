using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5OAuthButtons.Startup))]
namespace MVC5OAuthButtons
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
