using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using ABP.TPLMS.Controllers;
using ABP.TPLMS.Suppliers;
using ABP.TPLMS.Suppliers.Dto;
using ABP.TPLMS.Web.Models.Supplier;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABP.TPLMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class SupplierController : TPLMSControllerBase
    {
        const int MaxNum = 10;
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

            var module = (await _supplierAppService.GetAllAsync(new PagedSupplierResultRequestDto { MaxResultCount = MaxNum })).Items;
            // Paging not implemented yet
            SupplierDto cuModule = module.FirstOrDefault();
            var model = new SupplierListViewModel
            {

                Supplier = cuModule,
                Suppliers = module

            };
            return View(model);
        }

        private readonly ISupplierAppService _supplierAppService;

        public SupplierController(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;

        }

        public async Task<ActionResult> EditSupplierModal(int supplierId)
        {
            var module = await _supplierAppService.GetAsync(new EntityDto<int>(supplierId));
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SupplierDto, CreateUpdateSupplierDto>()).CreateMapper();
            CreateUpdateSupplierDto cuSupplier = mapper.Map<CreateUpdateSupplierDto>(module);
            var model = new EditSupplierModalViewModel
            {
                Supplier = cuSupplier

            };
            return View("_EditSupplierModal", model);
        }
    }
}
