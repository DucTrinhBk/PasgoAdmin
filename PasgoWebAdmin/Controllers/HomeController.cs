using PasgoWebAdmin.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PasgoWebAdmin.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            return View();
        }
        public PartialViewResult ThongTinCoBan()
        {
            DoiTacRender doiTac = new DoiTacRender();
            ViewBag.DVHC1 = new List<SelectListItem>() { new SelectListItem { Value = "1",Text="Hà Nội"}, new SelectListItem { Value = "2", Text = "TP HCM" }, new SelectListItem { Value = "3", Text = "Đà Nẵng" } };
            ViewBag.DVHC2 = new Dictionary<int, List<SelectListItem>>();
            ViewBag.DVHC2[1] = new List<SelectListItem>() { new SelectListItem { Value = "1", Text = "Hai Bà Trưng" } ,new SelectListItem { Value="2",Text="Hoàng Mai"},new SelectListItem { Value="3",Text="Đống Đa" } };
            ViewBag.DVHC2[2] = new List<SelectListItem>() { new SelectListItem { Value="1",Text="Quận 1" },new SelectListItem { Value = "2", Text = "Quận 2" } ,new SelectListItem { Value="3",Text="Quận 3"} };
            ViewBag.DVHC2[3] = new List<SelectListItem>() { new SelectListItem { Value = "1", Text = "Hải Châu" },new SelectListItem { Value="2",Text="Sơn Trà"} };
            
            return PartialView("~/Views/Home/SubViews/ThongTinCoBan.cshtml", doiTac);
        }
        [HttpPost]
        public ActionResult ThongTinCoBan(FormCollection data)
        {
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public PartialViewResult ThucDon()
        {
            return PartialView("~/Views/Home/SubViews/ThucDon.cshtml");
        }
        [HttpGet]
        public ActionResult BangThucDon()
        {
            List<MonAnRender> monAns = new List<MonAnRender>();
            for (int i = 0; i < 1000; i++)
            {
                monAns.Add(new MonAnRender(i));
            }
            return Json(monAns,JsonRequestBehavior.AllowGet);
        }
        public PartialViewResult Slide()
        {

            return PartialView("~/Views/Home/SubViews/Slide.cshtml");
        }
        public PartialViewResult BaiViet()
        {
            return PartialView("~/Views/Home/SubViews/BaiViet.cshtml", new BaiVietRender());
        }
    }
}