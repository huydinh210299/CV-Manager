using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class Enterprise
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public string Skype { get; set; }
        public string Position { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public EnterpriseInfo EnterpriseInfo { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public Acount Acount { get; set; }
        public Guid ID_Acount { get; set; }
    }
}
