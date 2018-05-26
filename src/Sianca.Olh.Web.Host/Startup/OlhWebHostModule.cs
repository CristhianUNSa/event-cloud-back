using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Sianca.Olh.Configuration;

namespace Sianca.Olh.Web.Host.Startup
{
    [DependsOn(
       typeof(OlhWebCoreModule))]
    public class OlhWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OlhWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OlhWebHostModule).GetAssembly());
        }
    }
}
