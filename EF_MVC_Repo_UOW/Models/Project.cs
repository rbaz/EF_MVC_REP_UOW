using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manageProjects.Models
{
    public class Project
    {
        public Guid ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CustomerMane { get; set; }
    }
}