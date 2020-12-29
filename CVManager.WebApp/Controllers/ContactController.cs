using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVManager.Application.Interface;
using CVManager.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVManager.WebApp.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            this._contactService = contactService;
        }
        [Route("apply")]
        [HttpGet]
        public IActionResult Apply()
        {
            var listContact = _contactService.getContactByType(1, 0);
            List<ContactModel> model = new List<ContactModel>();
            listContact.ForEach(c =>
            {
                model.Add(new ContactModel()
                {
                    ID=c.ID,
                    Address = c.ContactInfo is null ? "Chưa có thông tin" : c.ContactInfo.Address,
                    CompanyName = c.CompanyName,
                    Result = c.Result,
                    Time = c.ContactInfo is null ? DateTime.MaxValue : c.ContactInfo.Time,
                    Title = c.Post.Title
                });
            });
            return View(model);
        }

        [Route("invited")]
        [HttpGet]
        public IActionResult Invited()
        {
            var listContact = _contactService.getContactByType(1, 1);
            List<ContactModel> model = new List<ContactModel>();
            listContact.ForEach(c =>
            {
                model.Add(new ContactModel()
                {
                    ID = c.ID,
                    PostID = c.Post.ID,
                    Address = c.ContactInfo is null ? "Chưa có thông tin" : c.ContactInfo.Address,
                    CompanyName = c.CompanyName,
                    Result = c.Result,
                    Time = c.ContactInfo is null ? DateTime.MaxValue : c.ContactInfo.Time,
                    Title = c.Post.Title
                });
            });
            return View(model);
        }
    }
}
