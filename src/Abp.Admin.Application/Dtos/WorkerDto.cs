using System;
using Abp.Admin.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AutoMapper;

namespace Abp.Admin.Dtos
{
    [AutoMapFrom(typeof(Worker))]
    public class WorkerDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string IdentityImageUrl { get; set; }

        public CompanyDto Company { get; set; }
    }
}
