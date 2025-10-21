using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace catalog;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(catalogDomainSharedModule)
)]
public class catalogDomainModule : AbpModule
{

}
