using ShopV2.Models;
using ShopV2.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopV2.Controllers
{
    public class CustomerController : Controller
    {
        Models.UserContext db = new Models.UserContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel log)
        {

            var user = db.Customers.Where(m => m.cusPhone.Equals(log.phoneNum)).ToList();

            if (user.Count() > 0 )
            {
                if (user.SingleOrDefault().password.Equals(log.password))
                {
                    Session["accname"] = user.SingleOrDefault().cusFullName;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["accname"] = null;
                    ViewBag.LoginError = "Sai tài khoản hoặc mật khẩu.";
                    return View();
                }
                
            }
            return View();
        }
        public ActionResult Resgister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Resgister(Customer cus)
        {
            if (ModelState.IsValid)
            {
                //cus.cusFullName = "aa";
                //cus.password = "123";
                //cus.cusPhone = "123";
                //cus.cusMail = "123@acd";
                //cus.cusAddress = "HN";
                db.Customers.Add(cus);
                db.SaveChanges();
                return RedirectToAction("Login", "Customer");
            }
            return View();
        }     
        public ActionResult Logout()
        {
            Session["accname"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}