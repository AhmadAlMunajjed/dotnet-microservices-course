using catalog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace catalog;

public abstract class catalogController : AbpControllerBase
{
    protected catalogController()
    {
        LocalizationResource = typeof(catalogResource);
    }
}
