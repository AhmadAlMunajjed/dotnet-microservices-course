using dotnet_microservices_course.Localization;
using Volo.Abp.Application.Services;

namespace dotnet_microservices_course;

/* Inherit your application services from this class.
 */
public abstract class dotnet_microservices_courseAppService : ApplicationService
{
    protected dotnet_microservices_courseAppService()
    {
        LocalizationResource = typeof(dotnet_microservices_courseResource);
    }
}
