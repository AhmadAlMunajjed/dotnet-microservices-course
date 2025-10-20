using Volo.Abp.Modularity;

namespace dotnet_microservices_course;

/* Inherit from this class for your domain layer tests. */
public abstract class dotnet_microservices_courseDomainTestBase<TStartupModule> : dotnet_microservices_courseTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
