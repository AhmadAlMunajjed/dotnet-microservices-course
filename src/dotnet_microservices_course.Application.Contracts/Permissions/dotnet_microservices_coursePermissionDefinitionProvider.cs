using dotnet_microservices_course.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace dotnet_microservices_course.Permissions;

public class dotnet_microservices_coursePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(dotnet_microservices_coursePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(dotnet_microservices_coursePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(dotnet_microservices_coursePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(dotnet_microservices_coursePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(dotnet_microservices_coursePermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(dotnet_microservices_coursePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<dotnet_microservices_courseResource>(name);
    }
}
