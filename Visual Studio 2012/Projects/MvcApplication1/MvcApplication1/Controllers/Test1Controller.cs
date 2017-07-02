using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class Test1Controller : Controller
    {
        //
        // GET: /Test1/

        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Test1/
        [HttpPost]
        public ActionResult Login(String username, String password)
        {
            // truy van tu csdl, kiem tra thong tin dau vao va csdl, tra ve ket qua
            return View("Test1");
        }



    }
}
