using System;
using Abp.Admin.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AutoMapper;

namespace Abp.Admin.Dtos
{
    [AutoMapFrom(typeof(Company))]
    public class CompanyDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
