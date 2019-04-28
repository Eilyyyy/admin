using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Admin.Entities;
using Volo.Abp.AutoMapper;

namespace Abp.Admin.Dtos
{
    [AutoMapTo(typeof(Worker))]
    public class WorkerUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string IdentityImageUrl { get; set; }

        public Guid CompanyId { get; set; }
    }
}
