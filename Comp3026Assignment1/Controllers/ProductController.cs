using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comp3026Assignment1.Models;

namespace Comp3026Assignment1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(string searchString)
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}