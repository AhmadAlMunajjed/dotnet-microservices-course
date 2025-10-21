using AutoMapper;
using dotnet_microservices_course.Orders;

namespace catalog.Products;

public class OrderAutoMapperProfile : Profile
{
    public OrderAutoMapperProfile()
    {
        CreateMap<Order, OrderDto>();
        CreateMap<OrderItem, OrderItemDto>();
    }
}
