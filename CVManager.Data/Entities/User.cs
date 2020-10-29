using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public String Name { get; set; }
        public String School { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Area { get; set; }
        public Boolean Status { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public ICollection<CV> CVs { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
