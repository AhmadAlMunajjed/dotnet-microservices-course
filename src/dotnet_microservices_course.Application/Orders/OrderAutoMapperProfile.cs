using AutoMapper;
using dotnet_microservices_course.Orders;

namespace dotnet_microservices_course.Products;

public class OrderAutoMapperProfile : Profile
{
    public OrderAutoMapperProfile()
    {
        CreateMap<Order, OrderDto>();
        CreateMap<OrderItem, OrderItemDto>();
    }
}
