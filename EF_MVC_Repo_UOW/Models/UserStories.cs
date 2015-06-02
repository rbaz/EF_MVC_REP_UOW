using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manageProjects.Models
{
    public class UserStories
    {
        public Guid UserStoryID { get; set; }
        public string Story {get; set;}
        public string ProjectID {get; set;}
    }
}