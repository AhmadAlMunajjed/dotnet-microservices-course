using Volo.Abp.Modularity;

namespace dotnet_microservices_course;

public abstract class dotnet_microservices_courseApplicationTestBase<TStartupModule> : dotnet_microservices_courseTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
