using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ordering;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(orderingDomainSharedModule)
)]
public class orderingDomainModule : AbpModule
{

}
