using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace dotnet_microservices_course.Products;

public class Product : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; } = null!;
    public ProductType Type { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }
}
