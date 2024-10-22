﻿using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.Admin
{
    public class TeacherAdminController : Controller
    {
        KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            var values=context.Teachers.ToList();
            return View(values);
        }
    }
}