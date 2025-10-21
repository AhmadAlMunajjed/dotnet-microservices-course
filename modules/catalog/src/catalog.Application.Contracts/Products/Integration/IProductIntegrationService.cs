using System;
using System.Threading.Tasks;

namespace catalog.Products.Integration;

public interface IProductIntegrationService
{
    public Task<int> GetProductsCountByIds(Guid[] ids);
}
