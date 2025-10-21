using AutoMapper;

namespace catalog.Products;

public class ProductAutoMapperProfile : Profile
{
    public ProductAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();
    }
}
