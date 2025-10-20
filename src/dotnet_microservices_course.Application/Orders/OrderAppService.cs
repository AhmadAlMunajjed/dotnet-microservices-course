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
    public OrderAppService(IRepository<Order, Guid> repository) : base(repository)
    {
    }

    public override async Task<OrderDto> CreateAsync(CreateUpdateOrderDto input)
    {
        // MapToEntityAsync
        return await base.CreateAsync(input);
    }

    protected override async Task<Order> MapToEntityAsync(CreateUpdateOrderDto createInput)
    {
        return await base.MapToEntityAsync(createInput);
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
