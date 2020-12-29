using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.Interface;
using CVManager.Data.Entities;
using CVManager.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("profile")]
        public IActionResult Profile()
        {
            User user = _userService.getUserInfo();
            UserModel model = new UserModel()
            {
                ID = user.ID,
                Area = user.Area,
                Email = user.Email,
                Name = user.Name,
                Phone = user.Phone,
                School = user.School
            };
            return View(model);
        }

    }
}
