using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Admin.Dtos;
using Abp.Admin.Entities;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Admin.Services
{
    public class WorkerService : AsyncCrudAppService<Worker, WorkerDto, Guid, WorkerPageResultRequestDto, WorkerUpdateDto>, IWorkerService
    {
        public WorkerService(IRepository<Worker, Guid> repository) : base(repository)
        {
        }

        protected override IQueryable<Worker> CreateFilteredQuery(WorkerPageResultRequestDto input)
        {
            return Repository.WhereIf(!string.IsNullOrEmpty(input.Name), w => w.Name.StartsWith(input.Name));
        }
    }
}
