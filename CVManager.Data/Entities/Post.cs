using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class Post
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string ExactAddress { get; set; }
        public string Position { get; set; }
        public int Gender { get; set; }
        public string Salary { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }
        public int Experience { get; set; }
        public DateTime Submit_Deadline { get; set; }
        public string Reciever { get; set; }
        public string Email_Reciever { get; set; }
        public string Phone_Reciever { get; set; }
        public string Description { get; set; }
        public string Require { get; set; }
        public string Benefit { get; set; }
        public string Skill { get; set; }

        //public Guid ID_Enterprise { get; set; }
        public bool Status { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public Enterprise Enterprise { get; set; }

    }
}
