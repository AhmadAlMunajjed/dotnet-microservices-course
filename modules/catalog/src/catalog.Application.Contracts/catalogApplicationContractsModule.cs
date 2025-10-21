using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace catalog;

[DependsOn(
    typeof(catalogDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class catalogApplicationContractsModule : AbpModule
{

}
