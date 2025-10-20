using Volo.Abp.Modularity;

namespace dotnet_microservices_course;

[DependsOn(
    typeof(dotnet_microservices_courseApplicationModule),
    typeof(dotnet_microservices_courseDomainTestModule)
)]
public class dotnet_microservices_courseApplicationTestModule : AbpModule
{

}
