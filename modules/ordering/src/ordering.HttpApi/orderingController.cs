using ordering.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ordering;

public abstract class orderingController : AbpControllerBase
{
    protected orderingController()
    {
        LocalizationResource = typeof(orderingResource);
    }
}
