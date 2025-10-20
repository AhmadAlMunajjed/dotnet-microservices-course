using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using dotnet_microservices_course.Localization;

namespace dotnet_microservices_course.Web;

[Dependency(ReplaceServices = true)]
public class dotnet_microservices_courseBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<dotnet_microservices_courseResource> _localizer;

    public dotnet_microservices_courseBrandingProvider(IStringLocalizer<dotnet_microservices_courseResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
