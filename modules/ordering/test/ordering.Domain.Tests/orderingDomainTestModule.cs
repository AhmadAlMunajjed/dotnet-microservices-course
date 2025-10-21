using Volo.Abp.Modularity;

namespace ordering;

[DependsOn(
    typeof(orderingDomainModule),
    typeof(orderingTestBaseModule)
)]
public class orderingDomainTestModule : AbpModule
{

}
