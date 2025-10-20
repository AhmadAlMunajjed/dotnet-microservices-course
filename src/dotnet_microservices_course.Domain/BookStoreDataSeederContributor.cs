using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace dotnet_microservices_course;

public class dotnet_microservices_courseDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    public dotnet_microservices_courseDataSeederContributor()
    {
    }

    public async Task SeedAsync(DataSeedContext context)
    {

    }
}