using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopV2.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        Models.AdminContext db = new Models.AdminContext();
        Repository.ShopDAO dao = new Repository.ShopDAO();
        // GET: admin/Home
        public ActionResult Index()
        {
            if (Session["accname"]==null)
            {
              Session["accname"] = null;
              return RedirectToAction("Login", "Account");
            }
            else
            {
                var model = db.OrderDetails.ToList();
               return View(model);
            }

        }
    }
}