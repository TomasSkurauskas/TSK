using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSK.Data;

namespace TSK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITSKDbContext _context;

        public HomeController()
        {
            _context = new MyDbContext();
        }
        [Authorize]
        public ActionResult Test()
        {
            var test = _context.AspNetUsers.ToList();
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}