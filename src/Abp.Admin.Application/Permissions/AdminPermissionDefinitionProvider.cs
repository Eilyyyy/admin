﻿using Abp.Admin.Localization.Admin;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Admin.Permissions
{
    public class AdminPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AdminPermissions.GroupName);

            //Define your own permissions here. Examaple:
            //myGroup.AddPermission(AdminPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AdminResource>(name);
        }
    }
}
