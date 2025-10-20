using System;
using System.Threading.Tasks;

namespace dotnet_microservices_course.Products.Integration;

public interface IProductIntegrationService
{
    public Task<int> GetProductsCountByIds(Guid[] ids);
}
