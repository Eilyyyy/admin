using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Abp.Admin.Dtos
{
    public class AlainPageResultRequestDto : IPagedResultRequest
    {
        [Range(1, int.MaxValue)]
        public int Pi { get; set; } = 1;

        [Range(1, 100)]
        public int Ps { get; set; } = 10;
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
