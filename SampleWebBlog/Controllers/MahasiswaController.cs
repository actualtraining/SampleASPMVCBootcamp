using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleWebBlog.Models;

namespace SampleWebBlog.Controllers
{
    public class MahasiswaController : Controller
    {
        static List<Mahasiswa> lstMhs = new List<Mahasiswa>()
        {
            new Mahasiswa{Nim="77889911",Nama="Erick Kurniawan",
                Email ="erick@actual-training.com",IPK=3.2},
            new Mahasiswa{Nim="77889912",Nama="Bambang",
                Email="bambang@gmail.com",IPK=3.5},
            new Mahasiswa{Nim="77889913",Nama="Alex",
                Email="alex@gmail.com",IPK=3.1}
        };

        // GET: Mahasiswa
        public ActionResult Index(string keyword="")
        {
            List<Mahasiswa> results = lstMhs.OrderBy(m => m.Nama).ToList();
            if (keyword != string.Empty)
                results = 
                    lstMhs.Where(m => m.Nama.ToLower()
                    .Contains(keyword.ToLower()) || m.Nim.Contains(keyword)).ToList();

            return View(results);
        }

        // GET: Mahasiswa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mahasiswa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mahasiswa/Create
        [HttpPost]
        public ActionResult Create(Mahasiswa mahasiswa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    lstMhs.Add(mahasiswa);
                    return RedirectToAction("Index");
                }
                // TODO: Add insert logic here
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Mahasiswa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mahasiswa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mahasiswa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mahasiswa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
