﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlmostEmptyWebsite.Controllers
{
    public class HomeController : Controller
    {
        //An ASP.NET Action is a public method in a controller class
        public IActionResult Index()
        {
            //returns a webpage
            return View();
        }
    }
}