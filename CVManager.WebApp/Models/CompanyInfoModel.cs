using CVManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.WebApp.Models
{
    public class CompanyInfoModel
    {
        public string CompanyName { get; set; }
        public string Area { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public List<Post> Posts { get; set; }
        public string Scale { get; set; }
    }
}