using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace dotnet_microservices_course.Orders;

public class OrderDto : EntityDto<Guid>
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public List<OrderItemDto> Items { get; set; }
}

public class OrderItemDto
{
    public Guid Id { get; set; }
    public double Quantity { get; set; }
    public double Price { get; set; }
}
