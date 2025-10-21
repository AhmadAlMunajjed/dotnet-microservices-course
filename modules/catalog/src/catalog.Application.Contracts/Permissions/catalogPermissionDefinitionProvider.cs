using catalog.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace catalog.Permissions;

public class catalogPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(catalogPermissions.GroupName, L("Permission:catalog"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<catalogResource>(name);
    }
}
