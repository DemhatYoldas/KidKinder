using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialFacilities()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }

        public PartialViewResult PartialClassRooms()
        {
            return PartialView();
        }

        public PartialViewResult PartialBookASeat()
        {
            return PartialView();
        }

        public PartialViewResult PartialTeacher()
        {
            return PartialView();
        }

        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }

        //public PartialViewResult PartialBlog()
        //{
        //    return PartialView();
        //}

        public PartialViewResult PartialFooter() 
        {
            return PartialView();
        }

        public PartialViewResult PartialJavaScript()
        {
            return PartialView();
        }
    }
}