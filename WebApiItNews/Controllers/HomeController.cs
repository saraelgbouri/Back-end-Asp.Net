﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiItNews.Models;
using WebApiItNews.Data;

namespace WebApiItNews.Controllers
{
    public class HomeController :Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
