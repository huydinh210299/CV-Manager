using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.WebApp.Models
{
    public class UserModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
    }
}
