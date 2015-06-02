using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manageProjects.Models
{
    public class ProjectTasks
    {
        public Guid ProjectTaskID { get; set; }
        public string AssignedTo { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int TaskCompletion { get; set; }
        public string UserStoryID { get; set; }

    }
}