using RealEstateICA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateICA.Controllers
{
    public class HomeController : Controller
    {
        private RealEsContext real = new RealEsContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}