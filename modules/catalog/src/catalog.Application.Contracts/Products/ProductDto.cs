using System;
using Volo.Abp.Application.Dtos;

namespace catalog.Products;

public class ProductDto : EntityDto<Guid>
{
    public string? Name { get; set; }
    public ProductType? Type { get; set; }
    public double? Price { get; set; }
    public double? Quantity { get; set; }
}
