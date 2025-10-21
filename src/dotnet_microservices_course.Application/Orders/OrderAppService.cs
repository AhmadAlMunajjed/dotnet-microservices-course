using catalog.Products.Integration;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace dotnet_microservices_course.Orders;

public class OrderAppService : CrudAppService<
    Order,
    OrderDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CreateUpdateOrderDto>, IOrderAppService
{
    private readonly IDistributedEventBus _distributedEventBus;
    private readonly IProductIntegrationService _productService;

    public OrderAppService(
        IRepository<Order, Guid> repository,
        IDistributedEventBus distributedEventBus,
        IProductIntegrationService productService
        ) : base(repository)
    {
        _distributedEventBus = distributedEventBus;
        _productService = productService;
    }

    public override async Task<OrderDto> CreateAsync(CreateUpdateOrderDto input)
    {
        // MapToEntityAsync
        return await base.CreateAsync(input);
    }

    protected override async Task<Order> MapToEntityAsync(CreateUpdateOrderDto createInput)
    {
        var productIds = createInput.Items?.Select(i => i.ProductId.GetValueOrDefault()).ToArray() ?? [];
        var productCount = await _productService.GetProductsCountByIds(productIds);
        // validate all products exist
        if (productCount != productIds.Count())
        {
            throw new BusinessException("One or more products do not exist.");
        }

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
            await _distributedEventBus.PublishAsync(
                new catalog.Products.ProductQuantityChangedEto
                {
                    ProductId = item.ProductId.GetValueOrDefault(),
                    Quantity = item.Quantity.GetValueOrDefault()
                });
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
