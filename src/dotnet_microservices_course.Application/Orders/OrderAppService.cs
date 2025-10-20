﻿using System;
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
}
