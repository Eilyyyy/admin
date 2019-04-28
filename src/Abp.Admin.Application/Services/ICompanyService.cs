using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Admin.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Admin.Services
{
    public interface ICompanyService : IAsyncCrudAppService<CompanyDto, Guid, CompanyPageResultRequestDto, CompanyUpdateDto>
    {
    }

    public class CompanyPageResultRequestDto : AlainPageResultRequestDto
    {
        public string Name { get; set; }
    }
}
