using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bookthedoctor.Startup))]
namespace bookthedoctor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
