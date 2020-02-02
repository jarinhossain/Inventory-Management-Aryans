using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementV1.Models;
using InventoryManagementV1.Models.ViewModels;

namespace InventoryManagementV1.Controllers
{
    public class ProductController : Controller
    {
        DBContext db = new DBContext();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["CountryList"] = LoadCountry();
            ViewData["ColorList"] = LoadColor();
            ViewData["MaterialList"] = LoadMaterial();
            ViewData["CategoryList"] = LoadCategory();
            ViewData["SizeList"] = LoadSizeGroup();
           

            return View();
        }
        //[HttpPost]
        //public JsonResult Create(VMProduct pr)
        //{
        //    ViewData["CountryList"] = LoadCountry();
        //    ViewData["ColorList"] = LoadColor();

        //    Product product = new Product();
        //    product.Product_No = pr.Product_No;

        //    ProductQuantityMap productQuantityMap = new ProductQuantityMap();
        //    productQuantityMap.Material_Id = pr.Material_Id;

        //    db.ProductQuantityMaps.Add(productQuantityMap);
        //    db.Products.Add(product);

        //    db.SaveChanges();
        //    return Json("true", JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public JsonResult Create(Product product, ProductQuantityMap[] productQuantityList)
        {
            //db.Products.Add(product);
            //productQuantityMap.Product_Id = product.Id;
            //db.ProductQuantityMaps.Add(productQuantityMap);

            //db.SaveChanges();

            /// product has many ProductQuantityMap
            foreach (ProductQuantityMap item in productQuantityList)
            {
                product.ProductQuantityMaps.Add(item);
                item.Created_On = DateTime.Now;
            }

            db.Products.Add(product);
            product.Created_On = DateTime.Now;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewData["CountryList"] = LoadCountry();
            ViewData["ColorList"] = LoadColor();
            //ViewData["MaterialList"] = LoadMaterial();
            //ViewData["CategoryList"] = LoadCategory();
            //ViewData["SizeList"] = LoadSizeGroup();
            //ViewData["ProductList"] = LoadProduct();
            DBContext db = new DBContext();
            Product product = (from po in db.Products
                         where po.Id == id
                         select po).FirstOrDefault();
            return View(product);
        }
        [HttpPost]
        public JsonResult Edit(Product product)
        {
            ViewData["CountryList"] = LoadCountry();
            ViewData["ColorList"] = LoadColor();
            //ViewData["MaterialList"] = LoadMaterial();
            //ViewData["CategoryList"] = LoadCategory();
            //ViewData["SizeList"] = LoadSizeGroup();
            //ViewData["ProductList"] = LoadProduct();
            DBContext db = new DBContext();
            Product productDB = (from po in db.Products
                         where po.Id == product.Id
                         select po).FirstOrDefault();
            productDB.Product_No = product.Product_No;
            productDB.Product_Name = product.Product_Name;
            productDB.Product_Details = product.Product_Details;
            productDB.Country_Id = product.Country_Id;
            db.SaveChanges();
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        public List<SelectListItem> LoadCountry()
        {
            DBContext DB = new DBContext();
            List<Country> countrydb = (from coun in DB.Countries
                             select coun).ToList();
            List<SelectListItem> country = new List<SelectListItem>();
            foreach (var item in countrydb)
            {
                country.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Name });
            }
            return country;
        }
        public List<SelectListItem> LoadColor()
        {
            DBContext DB = new DBContext();
            List<Color> colordb = (from coun in DB.Colors
                                       select coun).ToList();
            List<SelectListItem> color = new List<SelectListItem>();
            foreach (var item in colordb)
            {
                color.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Color_Name });
            }
            return color;
        }
        public List<SelectListItem> LoadMaterial()
        {
            DBContext DB = new DBContext();
            List<Material> materialdb = (from coun in DB.Materials
                                   select coun).ToList();
            List<SelectListItem> material = new List<SelectListItem>();
            foreach (var item in materialdb)
            {
                material.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Material_Name });
            }
            return material;
        }
        public List<SelectListItem> LoadCategory()
        {
            DBContext DB = new DBContext();
            List<Category> categorydb = (from coun in DB.Categories
                                         select coun).ToList();
            List<SelectListItem> category = new List<SelectListItem>();
            foreach (var item in categorydb)
            {
                category.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Category_Name });
            }
            return category;
        }
        public List<SelectListItem> LoadSizeGroup()
        {
            DBContext DB = new DBContext();
            List<SizeGroup> sizegroupdb = (from coun in DB.SizeGroups
                                         select coun).ToList();
            List<SelectListItem> sizegroup = new List<SelectListItem>();
            foreach (var item in sizegroupdb)
            {
                sizegroup.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Size_Group_Range });
            }
            return sizegroup;
        }
        [HttpGet]
        public ActionResult Search()
        {


            DBContext DB = new DBContext();

            List<Product> product = (from pro in DB.Products
                                 select pro).ToList();

            return View(product);
        }

    }
}