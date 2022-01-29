using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineHouseRenting.Models;

namespace OnlineHouseRenting.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult indexadmin()
        {
            return View();
        }
        public ActionResult indexcustomer()
        {
            return View();
        }
        public ActionResult Contacts()
        {


            return View();
        }
        public ActionResult Buyingcustomer()
        {
            return View();
        }
        public ActionResult Rentingcustomer()
        {
            return View();
        }
        public ActionResult galleryadmin()
        {
            return View();
        }
        public ActionResult financecustomer()
        {
            return View();
        }
        public ActionResult sellingcustomer()
        {
            return View();
    }
        public ActionResult LoginAdmin()
        {
            return View();
    } 
        [HttpPost]
        public ActionResult LoginAdmin(tbl_admin admin)
        {
          int c = db.tbl_admin.Where(x => x.ADMIN_EMAIL == admin.ADMIN_EMAIL && x.ADMIN_PASSWORD == admin.ADMIN_PASSWORD).Count();
           if(c > 0)
            {
                return RedirectToAction("indexadmin");
            }
            else
            {
                ViewBag.message = "invalid Password or Email";
                return View();
            }

            return View();
    }

    }
}