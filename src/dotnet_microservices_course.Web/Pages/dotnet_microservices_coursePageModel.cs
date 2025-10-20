using dotnet_microservices_course.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace dotnet_microservices_course.Web.Pages;

public abstract class dotnet_microservices_coursePageModel : AbpPageModel
{
    protected dotnet_microservices_coursePageModel()
    {
        LocalizationResourceType = typeof(dotnet_microservices_courseResource);
    }
}
