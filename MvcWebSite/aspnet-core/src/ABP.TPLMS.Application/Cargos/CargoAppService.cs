using Abp.Application.Services;
using Abp.Domain.Repositories;
using ABP.TPLMS.Cargos.Dto;
using ABP.TPLMS.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABP.TPLMS.Cargos
{
    public class CargoAppService : AsyncCrudAppService<Cargo, CargoDto, int, PagedCargoResultRequestDto,
                            CreateUpdateCargoDto, CreateUpdateCargoDto>, ICargoAppService

    {
        public CargoAppService(IRepository<Cargo, int> repository)
            : base(repository)

        {

        }

    }
}
