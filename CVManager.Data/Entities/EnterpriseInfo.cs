using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class EnterpriseInfo
    {
        public Guid ID { get; set; }
        public string Company_Name { get; set; }
        public string Tax_Code { get; set; }
        public string Area { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Scale { get; set; }
        public Guid ID_Enterprise { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public Enterprise Enterprise { get; set; }
    }
}
