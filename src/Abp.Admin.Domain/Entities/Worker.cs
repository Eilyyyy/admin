using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Admin.Entities
{
    public class Worker : AuditedAggregateRoot<Guid>
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string IdentityImageUrl { get; set; }

        public Guid CompanyId { get; set; }
        [Required]
        public Company Company { get; set; }
    }
}
