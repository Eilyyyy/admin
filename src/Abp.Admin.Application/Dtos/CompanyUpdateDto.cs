using Abp.Admin.Entities;
using Volo.Abp.AutoMapper;

namespace Abp.Admin.Dtos
{
    [AutoMapTo(typeof(Company))]
    public class CompanyUpdateDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
