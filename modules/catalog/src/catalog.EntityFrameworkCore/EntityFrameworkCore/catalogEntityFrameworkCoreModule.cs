using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace catalog.EntityFrameworkCore;

[DependsOn(
    typeof(catalogDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class catalogEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<catalogDbContext>(options =>
        {
            options.AddDefaultRepositories<IcatalogDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
