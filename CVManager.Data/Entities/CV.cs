using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class CV
    {
        public Guid ID { get; set; }
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Html { get; set; }
        public String Css { get; set; }
        public String Type { get; set; }
        public String Path { get; set; }
        public int Status { get; set; }
        public Boolean Is_choosen { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public User User { get; set; }
    }
}
