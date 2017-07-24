using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Hello(int id, string nama, string alamat)
        {
            //test
            return Content("Hello " + nama + " ID anda " + id.ToString() + " alamat: " + alamat);
        }

        public ActionResult Registrasi()
        {
            ViewBag.Nama = "Erick Kurniawan";
            ViewBag.Email = "erick@actual-training.com";
            return View();
        }
    }
}