using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace dotnet_microservices_course.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class dotnet_microservices_courseDbContextFactory : IDesignTimeDbContextFactory<dotnet_microservices_courseDbContext>
{
    public dotnet_microservices_courseDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        dotnet_microservices_courseEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<dotnet_microservices_courseDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new dotnet_microservices_courseDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../dotnet_microservices_course.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
