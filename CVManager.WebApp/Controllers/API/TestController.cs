using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.Interface;
using CVManager.WebApp.Authentication;
using CVManager.Application.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    [Authorize(Roles = "ROLE_USER")]
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IJWTAuthentication jwtAuthenticationManager;
        private readonly IAcountService _acountService;
        public TestController(IJWTAuthentication jwtAuthenticationManager, IAcountService acountService)
        {
            this.jwtAuthenticationManager = jwtAuthenticationManager;
            this._acountService = acountService;
        }

        [HttpGet]
        public IEnumerable<String> get()
        {
            return new string[] { "Hello" };
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] UserRequest user)
        {
            var acount = await _acountService.get(user);
            var token = jwtAuthenticationManager.Authenticate(user.Username, user.Password, acount);
            if(token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
