using Volo.Abp.Modularity;

namespace ordering;

[DependsOn(
    typeof(orderingApplicationModule),
    typeof(orderingDomainTestModule)
    )]
public class orderingApplicationTestModule : AbpModule
{

}
