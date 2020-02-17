using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GolLabs.Authorization;

namespace GolLabs
{
    [DependsOn(
        typeof(GolLabsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GolLabsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GolLabsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GolLabsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
