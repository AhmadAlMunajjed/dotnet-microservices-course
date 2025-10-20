using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using dotnet_microservices_course.Data;
using Volo.Abp.DependencyInjection;

namespace dotnet_microservices_course.EntityFrameworkCore;

public class EntityFrameworkCoredotnet_microservices_courseDbSchemaMigrator
    : Idotnet_microservices_courseDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoredotnet_microservices_courseDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the dotnet_microservices_courseDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<dotnet_microservices_courseDbContext>()
            .Database
            .MigrateAsync();
    }
}
