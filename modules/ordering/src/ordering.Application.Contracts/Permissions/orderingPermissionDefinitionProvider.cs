using ordering.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ordering.Permissions;

public class orderingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(orderingPermissions.GroupName, L("Permission:ordering"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<orderingResource>(name);
    }
}
