using catalog.Products;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace catalog.EntityFrameworkCore;

[ConnectionStringName(catalogDbProperties.ConnectionStringName)]
public class catalogDbContext : AbpDbContext<catalogDbContext>, IcatalogDbContext
{
    public DbSet<Product> Products { get; set; }

    public catalogDbContext(DbContextOptions<catalogDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configurecatalog();
    }
}
