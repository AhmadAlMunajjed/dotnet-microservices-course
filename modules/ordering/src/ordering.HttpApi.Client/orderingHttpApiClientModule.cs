using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ordering;

[DependsOn(
    typeof(orderingApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class orderingHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(orderingApplicationContractsModule).Assembly,
            orderingRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<orderingHttpApiClientModule>();
        });

    }
}
