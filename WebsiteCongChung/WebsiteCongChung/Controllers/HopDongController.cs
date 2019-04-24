using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteCongChung.Models;

namespace WebsiteCongChung.Controllers
{
    public class HopDongController : Controller
    {
        // GET: HopDong
        public ActionResult Index()
        {
            return View();
        }

        // GET: HopDong/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: HopDong/Xem
        public ActionResult Xem()
        {
            return View("Create", HopDongViewModel.Sample);
        }

        // GET: HopDong/Create
        [HttpPost]
        public ActionResult Create(HopDongViewModel model)
        {
            return Redirect("Xem");
            
        }


        [HttpPost]
        public ActionResult InPhieuYeuCau(PhieuYeuCauViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Json("anh khong dep trai", JsonRequestBehavior.AllowGet);
            }

            return Json("anh dep trai", JsonRequestBehavior.AllowGet);
        }
    }
}