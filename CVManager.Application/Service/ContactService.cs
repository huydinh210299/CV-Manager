using CVManager.Application.DTO;
using CVManager.Application.Interface;
using CVManager.Data.EF;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace CVManager.Application.Service
{
    public class ContactService : IContactService
    {
        private readonly CVManagerDBContext _dbContext;
        private readonly IAcountProvider _acountProvider;
        public ContactService(CVManagerDBContext dbContext, IAcountProvider acountProvider)
        {
            this._dbContext = dbContext;
            this._acountProvider = acountProvider;
        }

        public int createContactByEnt(ContactRequest contact)
        {
            var User = _dbContext.Users.FirstOrDefault(u => u.ID == contact.UserID);
            var Post = _dbContext.Posts.Include(p => p.Enterprise).FirstOrDefault(p => p.ID == contact.PostID);
            var entID = Post.Enterprise.ID;
            var ent = _dbContext.Enterprises.Include(e => e.EnterpriseInfo).FirstOrDefault(e => e.ID == entID);
            var oldContact = _dbContext.Contacts.FirstOrDefault(c => c.User.ID == User.ID && c.Post.ID == Post.ID);
            if (oldContact is null)// Chưa có contact
            {
                var Contact = new Contact()
                {
                    CompanyName = ent.EnterpriseInfo.Company_Name,
                    Type = 1,
                    User = User,
                    Post = Post,
                    Result = "pending"
                };
                _dbContext.Contacts.Add(Contact);
                return _dbContext.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public List<Contact> getContactByType(int page, int type)
        {
            var userAcountID = Guid.Parse(_acountProvider.GetAcountID());
            var user = _dbContext.Users.Include(u => u.Acount).FirstOrDefault(u => u.Acount.ID == userAcountID);
            var userID = user.ID;

            var rs = _dbContext.Contacts.Include(c => c.ContactInfo)
                .Include(c => c.Post)
                .Include(c => c.User)
                .Where(c => c.User.ID == userID && c.Type == type).Skip(5 * (page - 1)).Take(5).ToList();

            return rs;
        }


        public int confirmContact(ContactConfirm contactConfirm)
        {
            var Contact = _dbContext.Contacts.FirstOrDefault(c => c.ID == contactConfirm.ContactID);
            if (contactConfirm.Type == "accept")
            {
                Contact.Result = "done";
            }
            else
            {
                Contact.Result = "fail";
            }
            return _dbContext.SaveChanges();
        }

        public int createContactByUser(UserContactrq userContactrq, Guid acountID)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Acount.ID == acountID);
            var post = _dbContext.Posts.FirstOrDefault(p => p.ID == userContactrq.PostID);
            var oldContact = _dbContext.Contacts
                .FirstOrDefault(c => c.User.ID == user.ID && c.Post.ID == userContactrq.PostID && c.Type == 0);
            if(oldContact is null)
            {
                var Contact = new Contact()
                {
                    CompanyName = userContactrq.CompanyName,
                    Type = 0,
                    User = user,
                    Post = post,
                    Result = "pending"
                };
                _dbContext.Contacts.Add(Contact);
                return _dbContext.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int Cancel(ContactConfirm contactConfirm)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(c => c.ID == contactConfirm.ContactID);
            _dbContext.Contacts.Remove(contact);
            return _dbContext.SaveChanges();
        }

        public List<Contact> getPostContact(Guid postID)
        {
            return _dbContext.Contacts.Include(c => c.ContactInfo).Include(c => c.User)
                    .Where(c => c.Post.ID == postID).ToList();
        }

        public async Task<int> updateContact(ConfirmContact confirmContact)
        {
            var listContact = _dbContext.Contacts.Include(c => c.ContactInfo)
                                .Where(c => confirmContact.ListContact.Contains(c.ID.ToString()) && c.Result != "fail").ToList();
            foreach (var item in listContact)
            {
                if(item.ContactInfo is null)
                {
                    var contactInfo = new ContactInfo()
                    {
                        Address = confirmContact.Address,
                        Time = confirmContact.Time,
                        Contact = item,
                        ID_Contact = item.ID
                    };
                    _dbContext.ContactInfos.Add(contactInfo);
                }
                else
                {
                    item.ContactInfo.Time = confirmContact.Time;
                    item.ContactInfo.Address = confirmContact.Address;
                }
                item.Result = "done";
            }
            return await _dbContext.SaveChangesAsync();
        }

        public int cancelContact(ContactConfirm contactConfirm)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(c => c.ID == contactConfirm.ContactID);
            contact.Result = "fail";
            return _dbContext.SaveChanges();
        }
    }
}
