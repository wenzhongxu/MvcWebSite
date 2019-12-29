using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABP.TPLMS.Cargos.Dto
{
    public class PagedCargoResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
