using Volo.Abp.Application.Services;
using ordering.host.Localization;

namespace ordering.host.Services;

/* Inherit your application services from this class. */
public abstract class hostAppService : ApplicationService
{
    protected hostAppService()
    {
        LocalizationResource = typeof(hostResource);
    }
}