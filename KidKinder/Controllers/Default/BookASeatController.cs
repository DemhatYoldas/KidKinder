using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;

namespace KidKinder.Controllers.Default
{
    public class BookASeatController : Controller
    {
        // GET: BookASeat
        public ActionResult Index()
        {
            return View();
        }
    }
}