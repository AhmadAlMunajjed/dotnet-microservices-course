using Volo.Abp.Modularity;

namespace catalog;

[DependsOn(
    typeof(catalogDomainModule),
    typeof(catalogTestBaseModule)
)]
public class catalogDomainTestModule : AbpModule
{

}
