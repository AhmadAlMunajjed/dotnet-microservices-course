using Volo.Abp.Reflection;

namespace catalog.Permissions;

public class catalogPermissions
{
    public const string GroupName = "catalog";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(catalogPermissions));
    }
}
