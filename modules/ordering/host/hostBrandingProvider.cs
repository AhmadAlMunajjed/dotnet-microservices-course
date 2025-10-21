using Microsoft.Extensions.Localization;
using ordering.host.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ordering.host;

[Dependency(ReplaceServices = true)]
public class hostBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<hostResource> _localizer;

    public hostBrandingProvider(IStringLocalizer<hostResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}