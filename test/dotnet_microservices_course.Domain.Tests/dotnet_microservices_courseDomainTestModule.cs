using Volo.Abp.Modularity;

namespace dotnet_microservices_course;

[DependsOn(
    typeof(dotnet_microservices_courseDomainModule),
    typeof(dotnet_microservices_courseTestBaseModule)
)]
public class dotnet_microservices_courseDomainTestModule : AbpModule
{

}
