﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Runtime.Validation;
using ABP.TPLMS.Controllers;
using ABP.TPLMS.Modules.Dto;
using ABP.TPLMS.Web.Models.Module;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABP.TPLMS.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class ModuleController : TPLMSControllerBase
    {
        private readonly IModuleAppService _moduleAppService;

        public ModuleController(IModuleAppService moduleAppService)
        {
            _moduleAppService = moduleAppService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var output = _moduleAppService.GetAllAsync();
            var model = new EditModuleModalViewModel
            {
                Module = new MapperConfiguration(cfg => cfg.CreateMap<ModuleDto, CreateUpdateModuleDto>()).CreateMapper().Map<CreateUpdateModuleDto>(output.Result.Items.FirstOrDefault()),
                Modules = output.Result.Items
            };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditModuleModalViewModel updateDto)
        {
            if (updateDto == null)
            {
                return NotFound();
            }
            if (updateDto.Module == null)
            {
                return NotFound();
            }
            _moduleAppService.CreateAsync(updateDto.Module);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [DisableValidation]
        public ActionResult Edit(int id, EditModuleModalViewModel updateDto)
        {
            if (id != updateDto.Module.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var module = updateDto.Module;
                    _moduleAppService.UpdateAsync(module);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DtoExists(updateDto.Module.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(updateDto);

        }

        private bool DtoExists(long id)
        {
            return _moduleAppService.GetAllAsync().Result.Items.Any(e => e.Id == id);
        }
        // GET: Cargoes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var module = _moduleAppService.GetAllAsync().Result.Items.SingleOrDefault(m => m.Id == id);
            if (module == null)
            {
                return NotFound();
            }
            var model = new EditModuleModalViewModel
            {
                Module = new MapperConfiguration(cfg => cfg.CreateMap<ModuleDto, CreateUpdateModuleDto>()).CreateMapper().Map<CreateUpdateModuleDto>(module)
            };
            return View(model);
            //return Ok(cargo.Result);
        }

        // GET: Cargoes/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var module = _moduleAppService.GetAllAsync().Result.Items.SingleOrDefault(m => m.Id == id);

            if (module == null)
            {
                return NotFound();
            }
            var model = new EditModuleModalViewModel
            {
                Module = new MapperConfiguration(cfg => cfg.CreateMap<ModuleDto, CreateUpdateModuleDto>()).CreateMapper().Map<CreateUpdateModuleDto>(module)
            };
            return View(model);
        }

        // POST: Cargoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _moduleAppService.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
                //throw;
            }
            return RedirectToAction(nameof(Index));
        }
    }
}