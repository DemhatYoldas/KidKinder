using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
using Microsoft.Ajax.Utilities;

namespace KidKinder.Controllers
{
    public class ContactController : Controller
    {
         KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
      
    }
}