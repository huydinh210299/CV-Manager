using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class Enterprise
    {
        public Guid ID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public Boolean Gender { get; set; }
        public String Skype { get; set; }
        public String Position { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public EnterpriseInfo EnterpriseInfo { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
