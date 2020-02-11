using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;
namespace InventoryManagementV1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
      [HttpGet]
        public ActionResult Create()
        {
            ViewData["JobList"] = LoadJob();
            return View();
        }
        [HttpPost]
        public JsonResult Create(User user)
        {
            ViewData["JobList"] = LoadJob();
            DBContext db = new DBContext();
            db.Users.Add(user);
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewData["JobList"] = LoadJob();
            DBContext db = new DBContext();
            User user = (from us in db.Users
                         where us.Id == id
                         select us).FirstOrDefault();
            return View(user);
        }
        [HttpPost]
        public JsonResult Edit(User userobj)
        {
            ViewData["JobList"] = LoadJob();
            DBContext db = new DBContext();
            User user = (from us in db.Users
                           where us.Id == userobj.Id
                           select us).FirstOrDefault();
            user.User_Name = userobj.User_Name;
            user.Password = userobj.Password;
            user.Mobile_No = userobj.Mobile_No;
            user.Email = userobj.Email;
            user.Address = userobj.Address;
            user.Voter_Id = userobj.Voter_Id;
            user.Job_Id = userobj.Job_Id;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        public List<SelectListItem> LoadJob()
        {
            DBContext DB = new DBContext();
            List<Job> job = (from j in DB.Jobs
                               select j).ToList();
            List<SelectListItem> jo = new List<SelectListItem>();
            foreach (var item in job)
            {
                jo.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Job_Title });
            }
            return jo;
        }
        [HttpGet]
        public ActionResult List()
        {
            DBContext DB = new DBContext();

            List<User> user = (from pro in DB.Users
                                     select pro).ToList();

            return View(user);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {


            DBContext DB = new DBContext();
            User user = (from u in DB.Users
                                 where u.Id == id
                                 select u).FirstOrDefault();

            return View(user);
        }
    }
}