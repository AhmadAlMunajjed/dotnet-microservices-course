using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnet_microservices_course.Orders;

public class CreateUpdateOrderDto
{
    [Required]
    public List<CreateUpdateOrderItemDto>? Items { get; set; }
}

public class CreateUpdateOrderItemDto
{
    [Required]
    public Guid? ProductId { get; set; }
    [Required]
    public double? Quantity { get; set; }
    [Required]
    public double? Price { get; set; }
}