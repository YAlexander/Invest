﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Invest.Site.Areas.Admin.Controllers
{
    public class ValuedPapersBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}