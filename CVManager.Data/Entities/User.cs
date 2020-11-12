using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
        public bool Status { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public ICollection<CV> CVs { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public Acount Acount { get; set; }
        public Guid ID_Acount { get; set; }
    }
}
