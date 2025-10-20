using AutoMapper;
using dotnet_microservices_course.Books;

namespace dotnet_microservices_course;

public class dotnet_microservices_courseApplicationAutoMapperProfile : Profile
{
    public dotnet_microservices_courseApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
