using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;

namespace Abp.Admin
{
    [AutoMapTo(typeof(Company))]
    public class CompanyUpdateDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
