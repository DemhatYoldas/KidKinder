using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class DefaultController : Controller
    {
        KidKinderContext context=new KidKinderContext();
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
            var values =context.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFacilities()
        {
            var values =context.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var degerabout=context.Abouts.ToList();
            var degeradboutlist=context.AboutLists.ToList();
            var model=new Tuple<List<About> , List<AboutList>>(degerabout, degeradboutlist);
            return PartialView(model);
        }

        public PartialViewResult PartialClassRooms()
        {
            var values =context.ClassRooms.ToList();
            return PartialView(values);
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