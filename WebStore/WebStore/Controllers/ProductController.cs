using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        WebStoreEntities db = new WebStoreEntities();
        public ActionResult ProductPartial()
        {
            return PartialView(db.Phones.Take(6).OrderBy(x => x.PhoneName).ToList());
        }
        public ViewResult DetailPhone(int MaPhone = 0)
        {
            Phone phones = db.Phones.SingleOrDefault(n => n.PhoneId == MaPhone);
            if(phones == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.TenSanPham = db.Products.Single(n => n.ProductId == phones.ProductId).ProductName;
            ViewBag.NSX = db.NSXes.Single(n => n.MaNSX == phones.MaNSX).TenNSX;
            return View(phones);
        }
    }
}