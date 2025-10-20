using dotnet_microservices_course.Products;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace dotnet_microservices_course.Orders;

public class OrderAppService : CrudAppService<
    Order,
    OrderDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CreateUpdateOrderDto>, IOrderAppService
{
    private readonly IRepository<Product, Guid> _productRepo;
    public OrderAppService(
        IRepository<Order, Guid> repository,
        IRepository<Product, Guid> productRepor) : base(repository)
    {
        _productRepo = productRepor;
    }

    public override async Task<OrderDto> CreateAsync(CreateUpdateOrderDto input)
    {
        // MapToEntityAsync
        return await base.CreateAsync(input);
    }

    protected override async Task<Order> MapToEntityAsync(CreateUpdateOrderDto createInput)
    {
        var order = new Order
        {
            Date = Clock.Now,
            Name = Guid.NewGuid().ToString(),
        };
        foreach (var item in createInput.Items ?? [])
        {
            order.Items.Add(new OrderItem
            {
                ProductId = item.ProductId.GetValueOrDefault(),
                Quantity = item.Quantity.GetValueOrDefault(),
                Price = item.Price.GetValueOrDefault()
            });
            var product = await _productRepo.GetAsync(item.ProductId.GetValueOrDefault());
            product.Quantity -= item.Quantity.GetValueOrDefault();
            await _productRepo.UpdateAsync(product);
        }
        return order;
    }

    public override async Task<OrderDto> UpdateAsync(Guid id, CreateUpdateOrderDto input)
    {
        return await base.UpdateAsync(id, input);
    }

    protected override async Task MapToEntityAsync(CreateUpdateOrderDto updateInput, Order entity)
    {
        await base.MapToEntityAsync(updateInput, entity);
    }
}
