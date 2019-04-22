using Volo.Abp;

namespace Abp.Admin
{
    public abstract class AdminApplicationTestBase : AbpIntegratedTest<AdminApplicationTestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
