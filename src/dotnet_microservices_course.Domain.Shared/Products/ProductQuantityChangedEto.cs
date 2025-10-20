using System;
using Volo.Abp.EventBus;

namespace dotnet_microservices_course.Products;

[EventName("ProductQuantityChangedEto")]
public class ProductQuantityChangedEto
{
    public Guid ProductId { get; set; }
    public double Quantity { get; set; }
}
