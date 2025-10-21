using dotnet_microservices_course.Products;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace catalog.EntityFrameworkCore;

[ConnectionStringName(catalogDbProperties.ConnectionStringName)]
public interface IcatalogDbContext : IEfCoreDbContext
{
    public DbSet<Product> Products { get; }
}
