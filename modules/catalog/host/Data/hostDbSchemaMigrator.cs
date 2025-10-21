using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace catalog.host.Data;

public class hostDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public hostDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the hostDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<hostDbContext>()
            .Database
            .MigrateAsync();

    }
}
