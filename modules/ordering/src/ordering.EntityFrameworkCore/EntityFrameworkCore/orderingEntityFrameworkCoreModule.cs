using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ordering.EntityFrameworkCore;

[DependsOn(
    typeof(orderingDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class orderingEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<orderingDbContext>(options =>
        {
            options.AddDefaultRepositories<IorderingDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
