using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleWebBlog.Models;
using SampleWebBlog.DAL;

namespace SampleWebBlog.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            var models = categoryDAL.GetAll();
            return View(models);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CategoryDAL categoryDal = new CategoryDAL();
                    categoryDal.Insert(category);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(string id)
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            var model = categoryDAL.GetById(id);
            return View(model);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CategoryDAL categoryDAL = new CategoryDAL();
                    categoryDAL.Update(id, category);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(string id)
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            var model = categoryDAL.GetById(id);
            return View(model);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, Category category)
        {
            try
            {
                CategoryDAL categoryDal = new CategoryDAL();
                categoryDal.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
