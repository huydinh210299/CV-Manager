using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class Contact
    {
        public Guid ID { get; set; }
        public Boolean Status { get; set; }
        public int Type { get; set; }
        public Boolean Result { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public User User { get; set; }
        public Enterprise Enterprise { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}
