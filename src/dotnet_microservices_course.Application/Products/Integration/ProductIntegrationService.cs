using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace dotnet_microservices_course.Products.Integration;

public class ProductIntegrationService : IProductIntegrationService, ITransientDependency
{
    private readonly IRepository<Product, Guid> _productRepo;

    public ProductIntegrationService(IRepository<Product, Guid> productRepo)
    {
        _productRepo = productRepo;
    }

    public async Task<int> GetProductsCountByIds(Guid[] ids)
    {
        var productQuery = await _productRepo.GetQueryableAsync();
        var products = productQuery.Where(x => ids.Contains(x.Id));
        return products.Count();
    }
}
