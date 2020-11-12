using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Data.Entities;
using CVManager.WebApp.Authentication;
using CVManager.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    [Route("CVBuilder")]
    public class CVBuilderController : Controller
    {   
        public IActionResult CVBuilder()
        {
            return View();
        }

    }
}
