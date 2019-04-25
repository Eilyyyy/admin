using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Admin.Services
{
    public interface ICompanyService : IAsyncCrudAppService<CompanyDto, Guid, PagedAndSortedResultRequestDto, CompanyUpdateDto>
    {
    }
}
