using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace dotnet_microservices_course.Data;

/* This is used if database provider does't define
 * Idotnet_microservices_courseDbSchemaMigrator implementation.
 */
public class Nulldotnet_microservices_courseDbSchemaMigrator : Idotnet_microservices_courseDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
