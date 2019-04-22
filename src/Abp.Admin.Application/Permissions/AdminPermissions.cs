using System;

namespace Abp.Admin.Permissions
{
    public static class AdminPermissions
    {
        public const string GroupName = "Admin";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static string[] GetAll()
        {
            //Return an array of all permissions
            return Array.Empty<string>();
        }
    }
}