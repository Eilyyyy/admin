using Abp.Admin.Localization.Admin;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.Admin.Pages
{
    public abstract class AdminPageModelBase : AbpPageModel
    {
        protected AdminPageModelBase()
        {
            LocalizationResourceType = typeof(AdminResource);
        }
    }
}