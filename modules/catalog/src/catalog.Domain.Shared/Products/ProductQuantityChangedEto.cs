using System;
using Volo.Abp.EventBus;

namespace catalog.Products;

[EventName("ProductQuantityChangedEto")]
public class ProductQuantityChangedEto
{
    public Guid ProductId { get; set; }
    public double Quantity { get; set; }
}
