using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;


namespace KidKinder.Controllers.Default
{
    public class CommunicationController : Controller
    {
        KidKinderContext context = new KidKinderContext();  
        public ActionResult Index()
        {
            var values=context.Communications.ToList();
            return View(values);
        }

        public PartialViewResult PartialCommunication()
        {
            ViewBag.description = context.Communications.Select(d =>d.Description).FirstOrDefault();
            ViewBag.address = context.Communications.Select(a => a.Address).FirstOrDefault();
            ViewBag.email = context.Communications.Select(e => e.Email).FirstOrDefault();
            ViewBag.phone = context.Communications.Select(p => p.Phone).FirstOrDefault();
            //ViewBag.day = context.Communications.Select(d => Day.).FirstOrDefault();
            //ViewBag.hour = context.Communications.Select(h => h.Hour).FirstOrDefault();
            return PartialView();
        }

    }
}