using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HEAPIFY_Manager_540.Startup))]
namespace HEAPIFY_Manager_540
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
