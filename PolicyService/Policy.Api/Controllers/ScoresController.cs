using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Policy.Api.Controllers
{
    public class ScoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
