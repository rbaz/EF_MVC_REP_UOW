using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_MVC_Repository_UOW.Models
{
    public class Employe
    {
        public Guid EmployeID { get; set; }
        public string EmployeName { get; set; }
        public string Designation { get; set; }
        public string ManagedID { get; set;}
        public string ContactNum { get; set; }
        public string EmailID { get; set; }

    }
}