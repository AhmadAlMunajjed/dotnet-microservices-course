using System;
using Volo.Abp.Domain.Entities;

namespace dotnet_microservices_course.Orders;

public class OrderItem : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public virtual Order? Order { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public string ProductType { get; set; } = null!;
    public double Price { get; set; }
    public double Quantity { get; set; }
    public double TotalPrice => Price * Quantity;
}
