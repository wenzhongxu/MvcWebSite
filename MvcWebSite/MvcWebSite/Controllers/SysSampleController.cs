using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apps.BLL;
using Apps.IBLL;
using Apps.Models.Sys;
using Unity.Attributes;

namespace MvcWebSite.Controllers
{
    public class SysSampleController : Controller
    {
        // GET: SysSample
        [Dependency]
        public ISysSampleBLL M_bll { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetList()
        {
            List<SysSampleModel> list = M_bll.GetList("");
            var json = new
            {
                total = list.Count,
                rows = (from r in list
                        select new SysSampleModel()
                        {
                            Id = r.Id,
                            Name = r.Name,
                            Age = r.Age,
                            Bir = r.Bir,
                            Photo = r.Photo,
                            Note = r.Note,
                            CreateTime = r.CreateTime
                        }).ToArray()
            };
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}