using dotnet_microservices_course.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace dotnet_microservices_course.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class dotnet_microservices_courseController : AbpControllerBase
{
    protected dotnet_microservices_courseController()
    {
        LocalizationResource = typeof(dotnet_microservices_courseResource);
    }
}
