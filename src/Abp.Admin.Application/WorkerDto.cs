using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AutoMapper;

namespace Abp.Admin
{
    [AutoMapFrom(typeof(Worker))]
    public class WorkerDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string IdentityImageUrl { get; set; }

        public CompanyDto Company { get; set; }
    }
}
