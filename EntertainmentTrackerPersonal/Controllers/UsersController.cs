﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;


namespace EntertainmentTrackerPersonal.Controllers
{

    public class UsersController : Controller
    {
        

        public ActionResult Login()
        {
            ViewBag.Message = "Login.";

            return View();
        }

       
    }
}

