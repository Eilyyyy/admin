using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Admin.Dtos;
using Abp.Admin.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Admin.Services
{
    public class CompanyService : AsyncCrudAppService<Company, CompanyDto, Guid, CompanyPageResultRequestDto, CompanyUpdateDto>, ICompanyService
    {
        public CompanyService(IRepository<Company, Guid> repository) : base(repository)
        {
        }

        protected override IQueryable<Company> CreateFilteredQuery(CompanyPageResultRequestDto input)
        {
            return Repository.WhereIf(!string.IsNullOrEmpty(input.Name), c => c.Name.StartsWith(input.Name));
        }
    }

}
