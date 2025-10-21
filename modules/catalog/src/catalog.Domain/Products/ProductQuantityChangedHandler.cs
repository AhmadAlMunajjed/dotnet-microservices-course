using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace dotnet_microservices_course.Products;

public class ProductQuantityChangedHandler :
    IDistributedEventHandler<ProductQuantityChangedEto>,
    ITransientDependency

{
    private readonly IRepository<Product, Guid> _productRepo;
    public ProductQuantityChangedHandler(IRepository<Product, Guid> productRepor)
    {
        _productRepo = productRepor;
    }

    public async Task HandleEventAsync(ProductQuantityChangedEto eventData)
    {
        var product = await _productRepo.GetAsync(eventData.ProductId);
        product.Quantity -= eventData.Quantity;
        await _productRepo.UpdateAsync(product);
    }
}
