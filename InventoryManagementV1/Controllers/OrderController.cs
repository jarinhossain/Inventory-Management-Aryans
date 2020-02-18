using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;
using System.Data.Entity;
using Newtonsoft.Json;

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
           
                return Json(customerDB, JsonRequestBehavior.AllowGet);
            
               
        }
        [HttpPost]
        public JsonResult ProductSearch(string Product_No)
        {
            /// method 1
            /// 
            Product productDB = (from pro in db.Products
                                 where pro.Product_No == Product_No
                                 select pro).FirstOrDefault();

            if (productDB != null)
            {
                List<ProductQuantityMap> quantity = (from pro in db.ProductQuantityMaps
                                                     where pro.Product_Id == productDB.Id
                                                     select pro)
                                                 .Include("Material")
                                                  .Include("Category")
                                                   .Include("SizeGroup")
                                                .Include("Color")

                                                .ToList();

                string json = JsonConvert.SerializeObject(quantity, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                return Json(json, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult OrderCreate(Order order)
        {
           foreach(var item in order.OrderDetails)
            {
                ProductQuantityMap pro = (from p in db.ProductQuantityMaps
                                          where p.Id == item.Product_Quantity_Id
                                          select p).FirstOrDefault();
             
                 pro.Quantity = pro.Quantity - item.Quantity;
              
            }
            order.Order_Date = DateTime.Now;
            db.Orders.Add(order);

            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult List()
        {
            List<Order> orderlist = (from pro in db.Orders
                                              select pro).Include("Customer").ToList();
            return View(orderlist);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            DBContext DB = new DBContext();
            Order order = (from u in DB.Orders
                               where u.Id == id
                               select u).FirstOrDefault();

            return View(order);
        }
    }
}
