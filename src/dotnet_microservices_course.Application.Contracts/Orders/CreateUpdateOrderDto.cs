using System.Collections.Generic;

namespace dotnet_microservices_course.Orders;

public class CreateUpdateOrderDto
{
    public List<CreateUpdateOrderItemDto> Items { get; set; }
}

public class CreateUpdateOrderItemDto
{
}