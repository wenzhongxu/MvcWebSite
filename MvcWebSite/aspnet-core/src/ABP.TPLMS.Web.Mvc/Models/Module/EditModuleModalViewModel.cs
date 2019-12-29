using ABP.TPLMS.Modules.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABP.TPLMS.Web.Models.Module
{
    public class EditModuleModalViewModel
    {
        public CreateUpdateModuleDto Module { get; set; }

        public IReadOnlyList<ModuleDto> Modules { get; set; }
    }
}
