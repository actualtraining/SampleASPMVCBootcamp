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

        public ActionResult Registrasi(string nama="",string email="")
        {
            List<string> lstNama = new List<string>();
            lstNama.Add("Erick");
            lstNama.Add("Budi");
            lstNama.Add("Alex");

            ViewBag.ListNama = lstNama;

            if (nama == string.Empty)
                ViewBag.Nama = "Erick Kurniawan";
            else
                ViewBag.Nama = nama;

            ViewBag.Email = (email == string.Empty ? "erick@gmail.com" : email);
           
            return View();
        }

        [HttpPost]
        public ActionResult FormRegistrasi(string firstname,string lastname,
            string email)
        {
            //return Content(firstname + " " + lastname + " " + email);
            ViewBag.FullName = firstname + " " + lastname;
            ViewBag.Email = email;
            return View();
        }
    }
}