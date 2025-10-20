using dotnet_microservices_course.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace dotnet_microservices_course.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(dotnet_microservices_courseEntityFrameworkCoreModule),
    typeof(dotnet_microservices_courseApplicationContractsModule)
)]
public class dotnet_microservices_courseDbMigratorModule : AbpModule
{
}
