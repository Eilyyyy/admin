using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Abp.Admin.Dtos
{
    public class AlainPageResultRequestDto : IPagedResultRequest
    {
        public int Pi { get; set; }
        public int Ps { get; set; }
        public int MaxResultCount
        {
            get => Ps;
            set => Ps = value;
        }
        public int SkipCount
        {
            get => (Pi - 1) * Ps;
            set => Pi = (value - 1) / Ps + 1;
        }
    }
}
