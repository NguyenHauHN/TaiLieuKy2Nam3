using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Login(String username, String password)
        {
            // truy van tu csdl, kiem tra thong tin dau vao va csdl, tra ve ket qua
            if ("admin".Equals(username) && "12345".Equals(password))
            {
                Session["username"] = username;
                return View("Index");
            }
            else
            {
                return View("Index");
            }
        }

    }
}
