using CVManager.Application.DTO;
using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Application.Interface
{
    public interface IContactService
    {
        int createContactByEnt(ContactRequest contact);
        List<Contact> getContactByType(int page, int type);
        int confirmContact(ContactConfirm contactConfirm);
        int createContactByUser(UserContactrq userContactrq, Guid acountID);
        int Cancel(ContactConfirm contactConfirm);
        List<Contact> getPostContact(Guid postID);
        Task<int> updateContact(ConfirmContact confirmContact);
        int cancelContact(ContactConfirm contactConfirm);
    }
}
