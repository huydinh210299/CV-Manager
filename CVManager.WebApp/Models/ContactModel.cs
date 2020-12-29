using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.WebApp.Models
{
    public class ContactModel
    {
        public Guid ID { get; set; }
        public Guid PostID { get; set; }
        public string Result { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public DateTime Time { get; set; }
    }
}
