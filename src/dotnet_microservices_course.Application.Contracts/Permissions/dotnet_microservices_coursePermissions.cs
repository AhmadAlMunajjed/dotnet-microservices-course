namespace dotnet_microservices_course.Permissions;

public static class dotnet_microservices_coursePermissions
{
    public const string GroupName = "dotnet_microservices_course";


    public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    
    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
