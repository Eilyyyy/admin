using System;
using System.Collections.Generic;
using System.Text;
using Abp.Admin.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Admin.Services
{
    public interface IWorkerService : IAsyncCrudAppService<WorkerDto, Guid, WorkerPageResultRequestDto, WorkerUpdateDto>
    {
    }

    public class WorkerPageResultRequestDto : AlainPageResultRequestDto
    {
        public string Name { get; set; }
    }
}
