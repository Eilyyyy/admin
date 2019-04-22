using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.Admin.Localization.Admin;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.Admin.Pages
{
    public abstract class AdminPageBase : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AdminResource> L { get; set; }
    }
}
