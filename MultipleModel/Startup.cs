using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleModel.Startup))]
namespace MultipleModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
