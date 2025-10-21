using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace catalog.Products;

public class ProductAppService :
    CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>,
    IProductAppService
{
    public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
    {
    }

    public async Task UpdateQuantity(Guid id, double quantity)
    {
        var product = await Repository.GetAsync(id);
        product.Quantity = quantity;
        await Repository.UpdateAsync(product);
    }
}
