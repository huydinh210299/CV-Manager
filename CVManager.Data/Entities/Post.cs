using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class Post
    {
        public Guid ID { get; set; }
        public String Title { get; set; }
        public String Address { get; set; }
        public String ExactAddress { get; set; }
        public String Position { get; set; }
        public int Gender { get; set; }
        public String Salary { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }
        public int Experience { get; set; }
        public DateTime Submit_Deadline { get; set; }
        public String Reciever { get; set; }
        public String Email_Reciever { get; set; }
        public String Phone_Reciever { get; set; }
        public String Description { get; set; }
        public String Require { get; set; }
        public String Benefit { get; set; }
        public String Skill { get; set; }

        //public Guid ID_Enterprise { get; set; }
        public Boolean Status { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public Enterprise Enterprise { get; set; }

    }
}
