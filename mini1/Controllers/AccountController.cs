using mini1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mini1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        UserDBEntities context = new UserDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            UserModel1 um = new UserModel1();
            return View(um);
        }

        [HttpPost]
        public ActionResult Register(UserModel1 um)
        {
            
            
                SignUpPage sp = new SignUpPage();
                sp.Password = um.Password;
                sp.UserId = um.UserId;
                sp.FirstName = um.FirstName;
                sp.LastName = um.LastName;
                sp.Gender = um.Gender;
                sp.DOB = DateTime.Parse(um.DOB);
                sp.Address = um.Address;
                context.SignUpPages.Add(sp);
                context.SaveChanges();
                um = new UserModel1();
        

            if (ModelState.IsValid == true)
            {
                ViewData["msg"] = "<script>alert('Your details are submitted successfully')</script>";
                ModelState.Clear();
            }
            return View(um);
        }

        public ActionResult Login()
        {
            LoginModel lm = new LoginModel();
            return View(lm);
        }

        [HttpPost]
        public ActionResult Login(LoginModel lm)
        {
            if(ModelState.IsValid)
            {
                if(context.SignUpPages.Where(m=>m.UserId==lm.UserId && m.Password==lm.Password).FirstOrDefault() ==null)
                {
                    ModelState.AddModelError("Error", "Invalid UserId or Password");
                    return View();
                }
                else
                {
                    Session["UserId"] = lm.UserId;
                   return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }

    }
}