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

        public ActionResult InPhieuYeuCau(HopDongViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Create", model);
            }

            return View("Create", model);
        }
    }
}