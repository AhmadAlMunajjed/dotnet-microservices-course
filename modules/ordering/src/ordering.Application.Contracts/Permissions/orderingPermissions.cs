using Volo.Abp.Reflection;

namespace ordering.Permissions;

public class orderingPermissions
{
    public const string GroupName = "ordering";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(orderingPermissions));
    }
}
