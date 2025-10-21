using ordering.Localization;
using Volo.Abp.Application.Services;

namespace ordering;

public abstract class orderingAppService : ApplicationService
{
    protected orderingAppService()
    {
        LocalizationResource = typeof(orderingResource);
        ObjectMapperContext = typeof(orderingApplicationModule);
    }
}
