using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.Interface;
using CVManager.Data.Entities;
using CVManager.WebApp.Authentication;
using CVManager.Application.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers.API
{
    [Route("api/user")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IJWTAuthentication _jwtAuthenticationManager;
        private readonly IAcountService _acountService;
        private readonly IUserService _userService;
        public LoginController(IJWTAuthentication jwtAuthenticationManager, IAcountService acountService, IUserService userService)
        {
            this._acountService = acountService;
            this._jwtAuthenticationManager = jwtAuthenticationManager;
            this._userService = userService;
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> authenticate([FromBody] UserRequest user)
        {
            var acount = await _acountService.get(user);
            String token = _jwtAuthenticationManager.Authenticate(user.Username, user.Password, acount);
            if (token == null) return Ok(new BaseResponse(400, "Đăng nhập thất bại. Mời kiểm tra lại thông tin"));
            else return Ok(new TokenResult(token)) ;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserAcountDetails userDetails)
        {
            int rs = await _userService.create(userDetails);
            if (rs == 0) return Ok(new BaseResponse(400, "Tạo mới không thành công.Tài khoản đã được sử dụng"));
            else
            {
                return Ok(new BaseResponse(200, "Tạo mới thành công"));
            }
        }
    }
}
