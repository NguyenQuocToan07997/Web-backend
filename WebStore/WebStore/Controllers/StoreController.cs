using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        WebStoreEntities db = new WebStoreEntities();
        public ActionResult StorePartial()
        {
            return PartialView(db.Phones.OrderBy(x => x.PhoneName).ToList());
        }
    }
}