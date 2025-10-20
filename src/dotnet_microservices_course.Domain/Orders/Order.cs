using System;
using System.Collections.Generic;
using System.Linq;
using Volo.Abp.Domain.Entities.Auditing;

namespace dotnet_microservices_course.Orders;

public class Order : AuditedAggregateRoot<Guid>
{
    public Order(Guid id)
    {
        Id = id;
    }

    public Order()
    {
        
    }

    public string Name { get; set; } = null!;
    public DateTime Date { get; set; }

    public ICollection<OrderItem> Items { get; set; } = [];
    public double Total => Items.Sum(x => x.Price * x.Quantity);
}
