using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;
using PagedList;
using PagedList.Mvc;

namespace WebStore.Controllers
{
    public class PhoneManagementController : Controller
    {
        // GET: PhoneManagement
        WebStoreEntities db = new WebStoreEntities();
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 5;
            return View(db.Phones.ToList().OrderBy(n => n.PhoneId).ToPagedList(pageNumber,pageSize));
        }
    }
}