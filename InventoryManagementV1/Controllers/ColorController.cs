using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;

namespace InventoryManagementV1.Controllers
{
    public class ColorController : Controller
    {
        DBContext db = new DBContext();
        // GET: Color
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
        public JsonResult Create(Color color)
        {
            db.Colors.Add(color);
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Color color = (from us in db.Colors
                                 where us.Id == id
                                 select us).FirstOrDefault();
            return View(color);
        }
        [HttpPost]
        public JsonResult Edit(Color color)
        {

            Color colordb = (from us in db.Colors
                                   where us.Id == color.Id
                                   select us).FirstOrDefault();
            colordb.Color_Name = color.Color_Name;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult List()
        {
            List<Color> colordb = (from pro in db.Colors
                                       select pro).ToList();
            return View(colordb);
        }
    }
}