using catalog.Products;
using System;
using Volo.Abp.Domain.Entities;

namespace dotnet_microservices_course.Orders;

public class OrderItem : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public virtual Order? Order { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product? Product { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }
    public double TotalPrice => Price * Quantity;
}
