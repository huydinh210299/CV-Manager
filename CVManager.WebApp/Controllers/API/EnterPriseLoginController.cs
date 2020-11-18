using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Data.Entities;
using CVManager.WebApp.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers.API
{
    [Route("api/ent")]
    [Authorize(Roles = "ROLE_ENTERPRISE")]
    [ApiController]
    public class EnterPriseLoginController : ControllerBase
    {
        private readonly IJWTAuthentication _jwtAuthenticationManager;
        private readonly IAcountService _acountService;
        private readonly IEnterpriseService _enterpriseService;

        public EnterPriseLoginController(IJWTAuthentication jwtAuthenticationManager, IAcountService acountService, IEnterpriseService enterpriseService)
        {
            this._acountService = acountService;
            this._jwtAuthenticationManager = jwtAuthenticationManager;
            this._enterpriseService = enterpriseService;
        }

        [AllowAnonymous]
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> login([FromBody] UserRequest user)
        {
            var acount = await _acountService.get(user);
            if(acount == null)
            {
                return Ok(new BaseResponse(400, "Đăng nhập thất bại. Mời kiểm tra lại thông tin"));
            }
            else
            {
                var role = acount.ObjectRole;
                if (role == "ROLE_ENTERPRISE")
                {
                    String token = _jwtAuthenticationManager.Authenticate(user.Username, user.Password, acount);
                    if (token == null) return Ok(new BaseResponse(400, "Đăng nhập thất bại. Mời kiểm tra lại thông tin"));
                    else return Ok(new TokenResult(token));
                }
                return Ok(new BaseResponse(400, "Đăng nhập thất bại. Mời kiểm tra lại thông tin"));
            }
        }

        [AllowAnonymous]
        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> register([FromBody] EntRegisterInfo entRegisterInfo)
        {
            var rs = await _enterpriseService.createEntAcount(entRegisterInfo);
            if(rs == 0)
            {
                return Ok(new BaseResponse(400, "Tên tài khoản đã được sử dụng"));
            }
            else
            {
                return Ok(new BaseResponse(200, "Tạo mới tài khoản thành công"));
            }
        }
        
        
        [Route("getid")]
        [HttpGet]
        public string getid()
        {
            return (User.Claims.FirstOrDefault(c => c.Type == "ID").Value);
        }
    }
}
