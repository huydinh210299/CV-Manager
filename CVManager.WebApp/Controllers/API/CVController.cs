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
using Microsoft.AspNetCore.Routing;

namespace CVManager.WebApp.Controllers.API
{
    [Authorize(Roles = "ROLE_USER")]
    [Route("api/cv")]
    [ApiController]
    public class CVController : ControllerBase
    {
        private readonly ICVService _cvService;
    
        public CVController(ICVService cvService)
        {
            this._cvService = cvService;
        }

        [AllowAnonymous]
        [Route("testsave")]
        [HttpPost]
        public void save([FromBody] CVInfo cvInfo)
        {
            _cvService.saveImage(cvInfo);
        }

        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> create([FromBody] CVInfo cvInfo)
        {
            int rs = await _cvService.create(cvInfo);
            if (rs == 1) { return Ok(new BaseResponse(200, "Tạo mới CV thành công")); }
            else
            {
                return Ok(new BaseResponse(400, "Tạo mới CV thất bại. Mời kiểm tra lại"));
            }
        }

        [Route("maincv")]
        [HttpPost]
        public async Task<IActionResult> setMainCV([FromBody] CVID cvID)
        {
            var ID = Guid.Parse(cvID.CvID);
            int rs = await _cvService.setMainCV(ID);
            if (rs == 1) return Ok(new BaseResponse(200, "Đặt CV chính thành công"));
            else
                return Ok(new BaseResponse(200, "CV đang được chọn là CV chính"));
        }

        [Route("edit")]
        [HttpPost]
        public async Task<IActionResult> editCv([FromBody] CVEdit cVEdit)
        {
            var rs = await _cvService.edit(cVEdit);
            if (rs == 0)
            {
                return Ok(new BaseResponse(400, "Cập nhật CV thất bại. Mời kiểm tra lại"));
            }
            else
            {
                return Ok(new BaseResponse(200, "Cạp nhật CV thành công"));
            }    
        }

        [AllowAnonymous]
        [Route("cvinfo")]
        [HttpGet]
        public CV CVInfo([FromQuery] Guid userid)
        {
            return _cvService.getMainByUserID(userid);
        }
    }
}
