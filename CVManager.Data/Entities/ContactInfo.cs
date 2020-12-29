using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CVManager.Data.Entities
{
    public class ContactInfo
    {
        public Guid ID { get; set; }
        public DateTime Time { get; set; }
        public string Address { get; set; }
        public Guid ID_Contact { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public Contact Contact { get; set; }
    }
}
