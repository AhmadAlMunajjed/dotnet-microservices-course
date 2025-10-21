using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ordering.EntityFrameworkCore;

[ConnectionStringName(orderingDbProperties.ConnectionStringName)]
public class orderingDbContext : AbpDbContext<orderingDbContext>, IorderingDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

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
