using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AutoMapper;

namespace Abp.Admin
{
    [AutoMapFrom(typeof(Company))]
    public class CompanyDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
