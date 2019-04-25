using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Admin.Services
{
    public class CompanyService : AsyncCrudAppService<Company, CompanyDto, Guid, PagedAndSortedResultRequestDto, CompanyUpdateDto>, ICompanyService
    {
        public CompanyService(IRepository<Company, Guid> repository) : base(repository)
        {
        }
    }
}
