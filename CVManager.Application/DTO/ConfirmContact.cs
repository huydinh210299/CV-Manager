using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Application.DTO
{
    public class ConfirmContact
    {
        public string Address { get; set; }
        public DateTime Time { get; set; }
        public string[] ListContact { get; set; }
    }
}
