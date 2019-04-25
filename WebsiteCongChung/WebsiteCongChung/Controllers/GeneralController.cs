using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteCongChung.Controllers
{
    [Authorize]
    public class GeneralController : Controller
    {
        [HttpPost]
        public ActionResult GetTemplates()
        {
            return Json(Models.General.LoaiHopDongViewModel.Samples, JsonRequestBehavior.AllowGet);
        }
    }
}