using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.DTO;
using CVManager.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers.API
{
    [Route("api/usercontact")]
    [ApiController]
    [Authorize(Roles = "ROLE_USER")]
    public class UserContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public UserContactController(IContactService contactService)
        {
            this._contactService = contactService;
        }

        [Route("confirm")]
        [HttpPost]
        public IActionResult confirmContact(ContactConfirm contactConfirm)
        {
            var rs = _contactService.confirmContact(contactConfirm);
            if (rs == 1)
            {
                return Ok(new BaseResponse(200, "Done"));
            }
            else
            {
                return Ok(new BaseResponse(400, "Failed"));
            }
        }

        [Route("recruitment")]
        [HttpPost]
        public IActionResult Recruitment(UserContactrq userContactrq)
        {
            var userID = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == "ID").Value);
            var rs = _contactService.createContactByUser(userContactrq, userID);
            if (rs == 1)
            {
                return Ok(new BaseResponse(200, "Done"));
            }
            else
            {
                return Ok(new BaseResponse(400, "Failed"));
            }
        }

        [Route("cancel")]
        [HttpPost]
        public IActionResult Cancle(ContactConfirm contactConfirm)
        {
            var rs = _contactService.Cancel(contactConfirm);
            if (rs == 1)
            {
                return Ok(new BaseResponse(200, "Done"));
            }
            else
            {
                return Ok(new BaseResponse(400, "Failed"));
            }
        }


    }
}
