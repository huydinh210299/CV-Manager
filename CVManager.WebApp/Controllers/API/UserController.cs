using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers.API
{


    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [Route("list")]
        [HttpGet]
        public List<UserAcountDetails> listUser([FromQuery] int? page, [FromQuery] string school)
        {
            return _userService.listUser(page, school);
        }

        [Route("save-profile")]
        [HttpPost]
        public async Task<IActionResult> saveProfile([FromBody] UserModel userModel)
        {
            var rs = await _userService.saveProfile(userModel.ID, userModel.Name, userModel.School, userModel.Phone, userModel.Email, userModel.Area);
            if (rs == 0)
            {
                return Ok(new BaseResponse(400, "Lưu thông tin thất bại. Mời kiểm tra lại!"));
            }
            else
            {
                return Ok(new BaseResponse(200, "Lưu thông tin thành công"));
            }
        }
    }
}
