using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace catalog;

[DependsOn(
    typeof(catalogApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class catalogHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(catalogApplicationContractsModule).Assembly,
            catalogRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<catalogHttpApiClientModule>();
        });

    }
}
