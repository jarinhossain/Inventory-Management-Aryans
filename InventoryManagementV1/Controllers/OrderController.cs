using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;

namespace InventoryManagementV1.Controllers
{
    public class OrderController : Controller
    {
        DBContext db = new DBContext();
        public OrderController()
        {
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: Order
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
        public JsonResult CustomerSearch(String Mobile1)
        {
           Customer customerDB = (from cus in db.Customers
                                   where cus.Mobile1 == Mobile1
                                  select cus).FirstOrDefault();
            return Json(customerDB,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult ProductSearch(string Product_No)
        {
            /// method 1
            Product productDB = (from pro in db.Products
                                 where pro.Product_No == Product_No
                                 select pro).FirstOrDefault();
            List<ProductQuantityMap> quantity = (from pro in db.ProductQuantityMaps
                                                 where pro.Product_Id == productDB.Id
                                                 select pro).ToList();

            /// method 2
            //List<ProductQuantityMap> map = (from quantityMap in db.ProductQuantityMaps
            //                                where quantityMap.Product.Product_No == Product_No
            //                                select quantityMap).ToList();
            return Json(quantity, JsonRequestBehavior.AllowGet);
        }
        
    }
}