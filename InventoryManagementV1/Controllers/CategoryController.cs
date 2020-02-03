using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;
namespace InventoryManagementV1.Controllers
{
    public class CategoryController : Controller
    {
        DBContext db = new DBContext();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category category = (from us in db.Categories
                                   where us.Id == id
                                   select us).FirstOrDefault();
            return View(category);
        }
        [HttpPost]
        public JsonResult Edit(Category category)
        {

            Category categorydb = (from us in db.Categories
                                     where us.Id == category.Id
                                     select us).FirstOrDefault();
            categorydb.Category_Name = category.Category_Name;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult List()
        {
            List<Category> category = (from pro in db.Categories
                                         select pro).ToList();
            return View(category);
        }
    }
}