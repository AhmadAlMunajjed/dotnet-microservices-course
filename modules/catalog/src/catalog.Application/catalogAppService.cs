using catalog.Localization;
using Volo.Abp.Application.Services;

namespace catalog;

public abstract class catalogAppService : ApplicationService
{
    protected catalogAppService()
    {
        LocalizationResource = typeof(catalogResource);
        ObjectMapperContext = typeof(catalogApplicationModule);
    }
}
