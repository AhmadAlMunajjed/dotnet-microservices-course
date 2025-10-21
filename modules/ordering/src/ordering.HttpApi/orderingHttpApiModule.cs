using Localization.Resources.AbpUi;
using ordering.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ordering;

[DependsOn(
    typeof(orderingApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class orderingHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(orderingHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<orderingResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
