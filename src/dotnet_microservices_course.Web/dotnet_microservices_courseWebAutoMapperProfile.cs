using AutoMapper;
using dotnet_microservices_course.Books;

namespace dotnet_microservices_course.Web;

public class dotnet_microservices_courseWebAutoMapperProfile : Profile
{
    public dotnet_microservices_courseWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
