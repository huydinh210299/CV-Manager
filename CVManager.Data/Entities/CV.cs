using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class CV
    {
        public Guid ID { get; set; }
        public string CvName { get; set; }
        public string Name { get; set; }
        public string  Phone { get; set; }
        public string Email { get; set; }
        public string Html { get; set; }
        public string Css { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }
        public bool Is_choosen { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public User User { get; set; }

    }
}
