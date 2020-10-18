using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopV2.Areas.admin.Controllers
{
    public class OrderController : Controller
    {
        Models.AdminContext dbCus = new Models.AdminContext();
        // GET: admin/Order
        public ActionResult Index(String name)
        {
            if (Session["accname"] == null)
            {
                Session["accname"] = null;
                return RedirectToAction("Login", "Account");
            }
            else
            {

                var model = dbCus.Orders.ToList();
                if (!string.IsNullOrEmpty(name))
                {
                    model = model.Where(p => p.orderID.Contains(name)).ToList();
                }
                return View(model);
            }
        }
    }
}