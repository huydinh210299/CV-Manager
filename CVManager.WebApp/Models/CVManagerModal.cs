using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVManager.WebApp.Models
{
    public class CVManagerModal
    {
        public Guid CVID { get; set; }
        public String CVName { get; set; }
        public String CVImage { get; set; }
        public DateTime CreateDate { get; set; }
        public bool isChoosen { get; set; }
    }
}
