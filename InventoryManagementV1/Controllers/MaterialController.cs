using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;

namespace InventoryManagementV1.Controllers
{
    public class MaterialController : Controller
    {
        DBContext db = new DBContext();
        // GET: Material
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
        public JsonResult Create(Material material)
        {
            db.Materials.Add(material);
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Material material = (from us in db.Materials
                         where us.Id == id
                         select us).FirstOrDefault();
            return View(material);
        }
        [HttpPost]
        public JsonResult Edit(Material material)
        {
          
            Material materialdb = (from us in db.Materials
                         where us.Id == material.Id
                         select us).FirstOrDefault();
            materialdb.Material_Name = material.Material_Name;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult List()
        {
            List<Material> material = (from pro in db.Materials
                               select pro).ToList();
            return View(material);
        }
    }
}