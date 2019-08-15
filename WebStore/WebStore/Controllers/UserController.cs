using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        WebStoreEntities db = new WebStoreEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(Register register)
        {
            if (ModelState.IsValid)
            {
                //chèn dữ liệu
                db.Registers.Add(register);
                //lưu vào csdl
                db.SaveChanges();
            }
            return View();
        }

        //đăng nhập
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection formCollection)
        {
            string sUsername = formCollection["txtUsername"].ToString();
            string sPassword = formCollection["txtPassword"].ToString();
            Register register = db.Registers.FirstOrDefault(n => n.Username == sUsername && n.Password == sPassword);
            if(register != null)
            {
                ViewBag.ThongBao = "Login Successfully!";
                Session["Username"] = register;
                return View();
            }
            ViewBag.ThongBao = "sUsername or Password is wrong!";
            return View();

        }

    }
}