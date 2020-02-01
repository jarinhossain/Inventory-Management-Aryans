using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;
namespace InventoryManagementV1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
          return View();
       }
        [HttpPost]
        public ActionResult Index(User user)
        {

            DBContext db = new DBContext();
            User userdb = (from us in db.Users
                          where us.User_Name == user.User_Name
                                 && us.Password == user.Password
                                 select us).FirstOrDefault();
            if (userdb != null)
            {
              
                return RedirectToAction("Create", "User");
            
            }
            return View();
        }
    }
}