using Volo.Abp.Modularity;

namespace catalog;

[DependsOn(
    typeof(catalogApplicationModule),
    typeof(catalogDomainTestModule)
    )]
public class catalogApplicationTestModule : AbpModule
{

}
