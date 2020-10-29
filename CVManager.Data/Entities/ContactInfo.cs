﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class ContactInfo
    {
        public Guid ID { get; set; }
        public DateTime Time { get; set; }
        public String Address { get; set; }
        public Guid ID_Contact { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public Contact Contact { get; set; }
    }
}
