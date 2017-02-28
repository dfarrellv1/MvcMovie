using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MvcMovie.Startup))]
namespace MvcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
