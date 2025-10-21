using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ordering.EntityFrameworkCore;

[ConnectionStringName(orderingDbProperties.ConnectionStringName)]
public interface IorderingDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
