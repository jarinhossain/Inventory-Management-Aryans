using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;
namespace InventoryManagementV1.Controllers
{
    public class SupplierController : Controller
    {
        DBContext db = new DBContext();
        // GET: Supplier
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
        public JsonResult Create(Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Supplier supplier = (from us in db.Suppliers
                                 where us.Id == id
                                 select us).FirstOrDefault();
            return View(supplier);
        }
        [HttpPost]
        public JsonResult Edit(Supplier supplier)
        {
            Supplier supplierdb = (from us in db.Suppliers
                                   where us.Id == supplier.Id
                                   select us).FirstOrDefault();
            supplierdb.Company_Name = supplier.Company_Name;
            supplierdb.Company_Address = supplier.Company_Address;
            supplierdb.Company_Mobile = supplier.Company_Mobile;
            supplierdb.Contact_Name = supplier.Contact_Name;
            supplierdb.Contact_Person_Number = supplier.Contact_Person_Number;
            supplierdb.Contact_Person_Address = supplier.Contact_Person_Address;
            supplierdb.Email = supplier.Email;
            supplierdb.Website = supplier.Website;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult List()
        {
            List<Supplier> supplierdb = (from pro in db.Suppliers
                                         select pro).ToList();
            return View(supplierdb);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Supplier supplierdb = (from u in db.Suppliers
                                 where u.Id == id
                                 select u).FirstOrDefault();

            return View(supplierdb);
        }
    }
}