using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace catalog.EntityFrameworkCore;

[ConnectionStringName(catalogDbProperties.ConnectionStringName)]
public interface IcatalogDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
