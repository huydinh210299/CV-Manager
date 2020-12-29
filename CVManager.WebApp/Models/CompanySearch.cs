using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.WebApp.Models
{
    public class CompanySearch
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int Page { get; set; }
    }
}
