using dotnet_microservices_course.Orders;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ordering.EntityFrameworkCore;

[ConnectionStringName(orderingDbProperties.ConnectionStringName)]
public interface IorderingDbContext : IEfCoreDbContext
{
    public DbSet<Order> Orders { get; }
    public DbSet<OrderItem> OrderItems { get; }
}
