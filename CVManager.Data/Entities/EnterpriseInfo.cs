using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Entities
{
    public class EnterpriseInfo
    {
        public Guid ID { get; set; }
        public String Company_Name { get; set; }
        public String Tax_Code { get; set; }
        public String Area { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Website { get; set; }
        public String Scale { get; set; }
        public Guid ID_Enterprise { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public Enterprise Enterprise { get; set; }
    }
}
