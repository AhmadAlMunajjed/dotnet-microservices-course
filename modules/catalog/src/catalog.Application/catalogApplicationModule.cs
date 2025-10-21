using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace catalog;

[DependsOn(
    typeof(catalogDomainModule),
    typeof(catalogApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class catalogApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<catalogApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<catalogApplicationModule>(validate: true);
        });
    }
}
