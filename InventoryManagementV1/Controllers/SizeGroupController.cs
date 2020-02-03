using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;

namespace InventoryManagementV1.Controllers
{
    public class SizeGroupController : Controller
    {
        DBContext db = new DBContext();
        // GET: SizeGroup
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
        public JsonResult Create(SizeGroup sizegroup)
        {
            db.SizeGroups.Add(sizegroup);
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            SizeGroup sizegroup = (from us in db.SizeGroups
                           where us.Id == id
                           select us).FirstOrDefault();
            return View(sizegroup);
        }
        [HttpPost]
        public JsonResult Edit(SizeGroup sizegroup)
        {

            SizeGroup sizegroupdb = (from us in db.SizeGroups
                             where us.Id == sizegroup.Id
                             select us).FirstOrDefault();
            sizegroupdb.Size_Group_Range = sizegroup.Size_Group_Range;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult List()
        {
            List<SizeGroup> sizegroup = (from pro in db.SizeGroups
                                   select pro).ToList();
            return View(sizegroup);
        }
    }
}