using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.Application.DTO
{
    public class UserAcountDetails
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
    }
}
