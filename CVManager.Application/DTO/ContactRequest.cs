using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Application.DTO
{
    public class ContactRequest
    {
        public Guid UserID { get; set; }
        public Guid PostID { get; set; }
    }
}
