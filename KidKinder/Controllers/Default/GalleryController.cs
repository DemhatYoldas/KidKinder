﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;


namespace KidKinder.Controllers.Default
{
    public class GalleryController : Controller
    {
        KidKinderContext context =new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialGallery()
        {
            return PartialView();
        }
    }
}