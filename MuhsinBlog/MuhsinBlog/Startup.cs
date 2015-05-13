using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuhsinBlog.Startup))]
namespace MuhsinBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
