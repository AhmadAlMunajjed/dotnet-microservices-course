using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ordering.host.Data;

public class hostDbContextFactory : IDesignTimeDbContextFactory<hostDbContext>
{
    public hostDbContext CreateDbContext(string[] args)
    {
        hostGlobalFeatureConfigurator.Configure();
        hostModuleExtensionConfigurator.Configure();

        hostEfCoreEntityExtensionMappings.Configure();
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<hostDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new hostDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}