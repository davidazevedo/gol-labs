using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GolLabs.Configuration;

namespace GolLabs.Web.Host.Startup
{
    [DependsOn(
       typeof(GolLabsWebCoreModule))]
    public class GolLabsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GolLabsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GolLabsWebHostModule).GetAssembly());
        }
    }
}
