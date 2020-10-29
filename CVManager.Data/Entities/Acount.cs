using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class Acount
    {
        public Guid ID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Guid ObjectId { get; set; }
        public String ObjectRole { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
    }
}
