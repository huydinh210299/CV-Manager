using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.WebApp.Models
{
    public class CompanyModel
    {
        public Guid EntID { get; set; }
        public string CompanyName { get; set; }
        public string Area { get; set; }
        public string Email { get; set; }
    }
}
