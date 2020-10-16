using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopV2.Areas.admin.Controllers
{
    public class CustomerController : Controller
    {
        Models.AdminContext dbCus = new Models.AdminContext();
        // GET: admin/Customer
        public ActionResult Index(string name)
        {
            if (Session["accname"] == null)
            {
                Session["accname"] = null;
                return RedirectToAction("Login", "Account");
            }
            else
            {

                var model = dbCus.Customers.ToList();
                if (!string.IsNullOrEmpty(name))
                {
                    model = model.Where(p => p.cusPhone.Contains(name)).ToList();
                }
                return View(model);
            }
        }
    }
}