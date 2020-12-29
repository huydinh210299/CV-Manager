using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CVManager.Data.Entities
{
    public class Contact
    {
        public Guid ID { get; set; }
        public string CompanyName { get; set; }
        public bool Status { get; set; }
        public int Type { get; set; }
        public string Result { get; set; }//pending, done, fail
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}
