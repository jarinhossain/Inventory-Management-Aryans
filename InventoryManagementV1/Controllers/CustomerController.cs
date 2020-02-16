using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;

namespace InventoryManagementV1.Controllers
{
    public class CustomerController : Controller
    {
        DBContext db = new DBContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["GenderList"] = LoadGender();
            ViewData["CommissionTypeList"] = loadCommissiontype();
            return View();
        }
        [HttpPost]
        public JsonResult Create(Customer customer)
        {
            customer.Created_On = DateTime.Now;
            db.Customers.Add(customer);
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewData["GenderList"] = LoadGender();
            ViewData["CommissionTypeList"] = loadCommissiontype();
            Customer customer = (from us in db.Customers
                                 where us.Id == id
                                 select us).FirstOrDefault();
            return View(customer);
        }
        [HttpPost]
        public JsonResult Edit(Customer customer)
        {
            Customer customerdb = (from us in db.Customers
                                   where us.Id == customer.Id
                                   select us).FirstOrDefault();
            customerdb.Customer_Name = customer.Customer_Name;
            customerdb.Mobile1 = customer.Mobile1;
            customerdb.Mobile2 = customer.Mobile2;
            customerdb.Gender_Id = customer.Gender_Id;
            customerdb.Commission_Type_Id = customer.Commission_Type_Id;
            customerdb.Address = customer.Address;
            customerdb.Guarantor_Name = customer.Guarantor_Name;
            customerdb.Guarantor_Mobile = customer.Guarantor_Mobile;
            customerdb.Guarantor_Address = customer.Guarantor_Address;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        public List<SelectListItem> LoadGender()
        {
            DBContext DB = new DBContext();
            List<Gender> genderdb = (from coun in DB.Genders
                                     select coun).ToList();
            List<SelectListItem> gender = new List<SelectListItem>();
            foreach (var item in genderdb)
            {
                gender.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Name });
            }
            return gender;
        }
        public List<SelectListItem> loadCommissiontype()
        {
            DBContext DB = new DBContext();
            List<CommissionType> Commissiondb = (from coun in DB.CommissionTypes
                                     select coun).ToList();
            List<SelectListItem> Commission = new List<SelectListItem>();
            foreach (var item in Commissiondb)
            {
                Commission.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Name });
            }
            return Commission;
        }
        [HttpGet]
        public ActionResult List()
        {
            List<Customer> customerdb = (from pro in db.Customers
                                   select pro).ToList();
            return View(customerdb);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {


            DBContext db = new DBContext();
            Customer customer = (from u in db.Customers
                               where u.Id == id
                               select u).FirstOrDefault();

            return View(customer);
        }
    }
}