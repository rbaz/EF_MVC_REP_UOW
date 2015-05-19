using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_MVC_Repository_UOW.Models
{
    public class Employe
    {
        public int EmployeID { get; set; }
        public string EmployeName { get; set; }
        public string Designation { get; set; }
        public int ManagedID { get; set;}
        public string ContactNum { get; set; }
        public string EmailID { get; set; }

    }
}