using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace dotnet_microservices_course.Orders;

public interface IOrderAppService : ICrudAppService<
    OrderDto, 
    Guid, 
    PagedAndSortedResultRequestDto, 
    CreateUpdateOrderDto>
{
}
