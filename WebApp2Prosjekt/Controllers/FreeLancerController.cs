﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2Prosjekt.Controllers
{
    public class FreeLancerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}