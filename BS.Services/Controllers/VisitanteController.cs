using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BS.Services.Controllers
{
    public class VisitanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}