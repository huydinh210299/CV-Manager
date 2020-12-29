using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers.API
{
    [Route("api/contact")]
    [Authorize(Roles = "ROLE_ENTERPRISE")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            this._contactService = contactService;
        }

        [Route("entcreate")]
        [HttpPost]
        public IActionResult entCreate(ContactRequest contact)
        {
            var rs = _contactService.createContactByEnt(contact);
            if (rs == 1)
            {
                return Ok(new BaseResponse(200, "Tạo contact thành công"));
            }
            else
            {
                return Ok(new BaseResponse(400, "Tạo contact thất bại"));
            }
        }

        [Route("listcontact/{postID}")]
        [HttpGet]
        public List<Contact> listContat(string postID)
        {
            var postid = Guid.Parse(postID);
            var rs =  _contactService.getPostContact(postid);
            return rs;
        }

        [Route("update")]
        [HttpPost]
        public async Task<IActionResult> updateContact([FromBody] ConfirmContact confirmContact)
        {
            var rs = await _contactService.updateContact(confirmContact);
            if (rs == 1)
            {
                return Ok(new BaseResponse(200, "done"));
            }
            else
            {
                return Ok(new BaseResponse(400, "failed"));
            }
        }

        [Route("cancel")]
        [HttpPost]
        public  IActionResult cancelContact([FromBody] ContactConfirm contactConfirm)
        {
            var rs =  _contactService.cancelContact(contactConfirm);
            if (rs == 1)
            {
                return Ok(new BaseResponse(200, "done"));
            }
            else
            {
                return Ok(new BaseResponse(400, "failed"));
            }
        }
    }
}
