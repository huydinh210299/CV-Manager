using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    public class CVBuilderController : Controller
    {
        [Route("CVBuilder")]
        public IActionResult CVBuilder()
        {
            return View();
        }
    }
}
