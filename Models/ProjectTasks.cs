using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_MVC_Repository_UOW.Models
{
    public class ProjectTasks
    {
        public int ProjectTaskID { get; set; }
        public int AssignedTo { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int TaskCompletion { get; set; }
        public int UserStoryID { get; set; }

    }
}