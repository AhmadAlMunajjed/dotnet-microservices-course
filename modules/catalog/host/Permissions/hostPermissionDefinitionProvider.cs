using catalog.host.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace catalog.host.Permissions;

public class hostPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(hostPermissions.GroupName);


        
        //Define your own permissions here. Example:
        //myGroup.AddPermission(hostPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<hostResource>(name);
    }
}
