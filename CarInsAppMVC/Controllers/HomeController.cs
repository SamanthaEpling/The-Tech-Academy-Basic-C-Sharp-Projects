﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "CarInsApp";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Samantha Epling Contact Info.";

            return View();
        }
        
    }
}