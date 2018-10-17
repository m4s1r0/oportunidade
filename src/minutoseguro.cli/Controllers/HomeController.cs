using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using minutoseguro.cli.Models;
using minutoseguro.cli.Code;

namespace minutoseguro.cli.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(FeedsSerializer.GetPosts());
        }
    }
}
