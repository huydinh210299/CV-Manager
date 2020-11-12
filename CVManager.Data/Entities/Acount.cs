using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class Acount
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ObjectRole { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public User User { get; set; }
        public Enterprise Enterprise { get; set; }
    }
}
