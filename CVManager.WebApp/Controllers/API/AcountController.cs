using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Application.Service;
using CVManager.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcountController : ControllerBase
    {
        private readonly IAcountService _acountService;
        public AcountController(IAcountService acountService)
        {
            this._acountService = acountService;
        }

        [HttpGet]
        public async Task<Acount> get()
        {
            UserRequest user = new UserRequest() { Username = "dinhlun99hy", Password = "boladinh99" };
            var acount = await _acountService.get(user);
            return acount;
        }

        //[HttpGet]
        //public IEnumerable<String> get()
        //{
        //    return new string[] { "Hello" };
        //}
    }
}
