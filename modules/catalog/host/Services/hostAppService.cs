using Volo.Abp.Application.Services;
using catalog.host.Localization;

namespace catalog.host.Services;

/* Inherit your application services from this class. */
public abstract class hostAppService : ApplicationService
{
    protected hostAppService()
    {
        LocalizationResource = typeof(hostResource);
    }
}