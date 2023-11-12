using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA.EF;
using DATA;

namespace DoAn.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            mapAccount map = new mapAccount();
            var account = map.Find(email, password);
            //1. Có thì sang trang admin dashboard
            if (account != null)
            {

            }
            return View();
        }
    }
}