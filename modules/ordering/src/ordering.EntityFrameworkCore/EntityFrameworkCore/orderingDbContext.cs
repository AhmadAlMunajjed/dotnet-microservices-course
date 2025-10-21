using dotnet_microservices_course.Orders;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ordering.EntityFrameworkCore;

[ConnectionStringName(orderingDbProperties.ConnectionStringName)]
public class orderingDbContext : AbpDbContext<orderingDbContext>, IorderingDbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public orderingDbContext(DbContextOptions<orderingDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configureordering();
    }
}
